using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MMForm.FormulariosData
{
    public partial class HistorialForm : Form
    {

        Helpers helper = new Helpers();
        public HistorialForm()
        {
            InitializeComponent();
        }

        private void HistorialForm_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
            CargarGraficoIngresos();
            CargarGraficoGanancias();
            CargarGraficoVendedores();
            CargarGraficoProductosMasVendidos();
        }


        private async void CargarDataGrid()
        {
            await helper.GetAllProductos();
            await helper.GetAllPreventas();
            await helper.GetAllPreventaProductos();
            await helper.GetAllVentas();
            await helper.GetAllUsuarios(); // Asegúrate de cargar la lista de usuarios también

            var Productos = helper.RetornarProductos();
            var Preventas = helper.RetornarPreventas();
            var PreventaProductos = helper.RetornarPreventaProductos();
            var Ventas = helper.RetornarVentas();
            var Usuarios = helper.RetornarUsuarios(); // Obtener todos los usuarios

            var historial = Preventas
                .Join(PreventaProductos,
                      preventa => preventa.Id,
                      preventaProducto => preventaProducto.PreventaId,
                      (preventa, preventaProducto) => new { preventa, preventaProducto })
                .Join(Productos,
                      pp => pp.preventaProducto.ProductoId,
                      producto => producto.Id,
                      (pp, producto) => new { pp.preventa, pp.preventaProducto, producto })
                .Join(Ventas,
                      ppv => ppv.preventa.Id,
                      venta => venta.PreventaId,
                      (ppv, venta) => new { ppv.preventa, ppv.preventaProducto, ppv.producto, venta })
                .GroupBy(item => item.preventa.Fecha.Date)
                .Select(grupo => new
                {
                    Fecha = grupo.Key,
                    TotalVentas = grupo.Sum(x => x.venta.Total),
                    UnidadesVendidas = grupo.Sum(x => x.preventaProducto.Cantidad),
                    ProductoMasVendido = grupo.GroupBy(x => x.producto.Nombre)
                                              .OrderByDescending(p => p.Sum(x => x.preventaProducto.Cantidad))
                                              .First().Key,
                    // Obtener el nombre del vendedor usando su UsuarioId
                    VendedorMasVentas = grupo.GroupBy(x => x.preventa.UsuarioId)
                                             .OrderByDescending(u => u.Sum(x => x.venta.Total))
                                             .Select(u => u.Key).First() // Obtener el UsuarioId
                })
                .ToList();

            // Convertir los datos a un formato que incluya el nombre del vendedor
            var historialConNombres = historial.Select(item => new
            {
                item.Fecha,
                item.TotalVentas,
                item.UnidadesVendidas,
                item.ProductoMasVendido,
                // Buscar el nombre del vendedor
                VendedorMasVentas = Usuarios.FirstOrDefault(u => u.Id == item.VendedorMasVentas)?.Username ?? "Desconocido"
            }).ToList();

            dataGridView1.DataSource = historialConNombres;
        }



        private async void CargarGraficoIngresos()
        {
            await helper.GetAllProductos();
            await helper.GetAllPreventas();
            await helper.GetAllPreventaProductos();
            await helper.GetAllVentas();

            var Productos = helper.RetornarProductos();
            var Preventas = helper.RetornarPreventas();
            var PreventaProductos = helper.RetornarPreventaProductos();
            var Ventas = helper.RetornarVentas();

            var ingresosPorMes = Preventas
                .Join(Ventas,
                      preventa => preventa.Id,
                      venta => venta.PreventaId,
                      (preventa, venta) => new { preventa.Fecha, venta.Total })
                .GroupBy(item => new { item.Fecha.Year, item.Fecha.Month })  // Agrupar por Año y Mes
                .Select(grupo => new
                {
                    Fecha = new DateTime(grupo.Key.Year, grupo.Key.Month, 1),  // Convertimos a DateTime para ordenar
                    TotalIngresos = grupo.Sum(x => x.Total)
                })
                .OrderBy(item => item.Fecha) // Ordenar por Fecha ascendente
                .ToList();

            chartIngresos.Series.Clear();
            chartIngresos.ChartAreas[0].AxisX.CustomLabels.Clear();

            var seriesIngresos = new Series
            {
                ChartType = SeriesChartType.Column,
                Name = "Ingresos",
                BorderWidth = 2,
                Color = Color.Green,
            };

            int index = 0; // Índice para las etiquetas en el eje X
            foreach (var mes in ingresosPorMes)
            {
                seriesIngresos.Points.AddXY(index, mes.TotalIngresos);
                chartIngresos.ChartAreas[0].AxisX.CustomLabels.Add(index - 0.5, index + 0.5, mes.Fecha.ToString("yyyy-MM"));
                index++;
            }

            chartIngresos.Series.Add(seriesIngresos);
            chartIngresos.Titles.Clear();
            chartIngresos.Titles.Add("Ingresos por Mes");

            // Opcional: Configurar formato y estilo del eje X
            chartIngresos.ChartAreas[0].AxisX.Interval = 1;
            chartIngresos.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Inclina las etiquetas si es necesario
            chartIngresos.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 6);
        }




        private async void CargarGraficoGanancias()
        {
            await helper.GetAllProductos();
            await helper.GetAllPreventas();
            await helper.GetAllPreventaProductos();
            await helper.GetAllVentas();

            var Productos = helper.RetornarProductos();
            var Preventas = helper.RetornarPreventas();
            var PreventaProductos = helper.RetornarPreventaProductos();
            var Ventas = helper.RetornarVentas();

            var gananciasPorMes = Preventas
                .Join(PreventaProductos,
                      preventa => preventa.Id,
                      preventaProducto => preventaProducto.PreventaId,
                      (preventa, preventaProducto) => new { preventa.Fecha, preventaProducto.ProductoId, preventaProducto.Cantidad })
                .Join(Productos,
                      preventaProducto => preventaProducto.ProductoId,
                      producto => producto.Id,
                      (preventaProducto, producto) => new
                      {
                          Fecha = preventaProducto.Fecha,
                          Cantidad = preventaProducto.Cantidad,
                          PrecioVenta = producto.PrecioVenta,
                          Costo = producto.Costo
                      })
                .GroupBy(item => new { item.Fecha.Year, item.Fecha.Month })  // Agrupando por Año y Mes
                .Select(grupo => new
                {
                    Fecha = new DateTime(grupo.Key.Year, grupo.Key.Month, 1),  // Convertimos a DateTime para ordenar
                    Ganancia = grupo.Sum(x => (x.PrecioVenta * x.Cantidad) - (x.Costo * x.Cantidad))
                })
                .OrderBy(item => item.Fecha) // Ordenamos por la fecha
                .ToList();

            chartGanancias.Series.Clear();
            chartGanancias.ChartAreas[0].AxisX.CustomLabels.Clear();

            var seriesGanancias = new Series
            {
                ChartType = SeriesChartType.Line,
                Name = "Ganancias",
                BorderWidth = 4, // Aumenta el grosor de la línea
                Color = Color.Red, // Cambia el color de la línea a rojo
                MarkerStyle = MarkerStyle.Circle, // Agrega marcadores a los puntos
                MarkerSize = 6, // Tamaño de los marcadores
                MarkerColor = Color.Blue, // Color de los marcadores
            };

            int index = 0; // Índice para las etiquetas del eje X
            foreach (var mes in gananciasPorMes)
            {
                seriesGanancias.Points.AddXY(index, mes.Ganancia);
                chartGanancias.ChartAreas[0].AxisX.CustomLabels.Add(index - 0.5, index + 0.5, mes.Fecha.ToString("yyyy-MM"));
                index++;
            }

            chartGanancias.Series.Add(seriesGanancias);
            chartGanancias.Titles.Clear();
            chartGanancias.Titles.Add("Ganancias por Mes");

            // Opcional: Configurar el estilo del gráfico
            chartGanancias.ChartAreas[0].AxisX.Interval = 1;
            chartGanancias.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Inclina las etiquetas del eje X
            chartGanancias.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 6);
        }



        private async void CargarGraficoVendedores()
        {
            await helper.GetAllProductos();
            await helper.GetAllPreventas();
            await helper.GetAllPreventaProductos();
            await helper.GetAllVentas();
            await helper.GetAllUsuarios(); // Asegúrate de que este método obtenga la lista de usuarios

            var Productos = helper.RetornarProductos();
            var Preventas = helper.RetornarPreventas();
            var PreventaProductos = helper.RetornarPreventaProductos();
            var Ventas = helper.RetornarVentas();
            var Usuarios = helper.RetornarUsuarios(); // Obtén todos los usuarios

            var vendedoresDestacados = Preventas
                .Join(Ventas,
                      preventa => preventa.Id,
                      venta => venta.PreventaId,
                      (preventa, venta) => new { preventa.UsuarioId, venta.Total })
                .GroupBy(p => p.UsuarioId)
                .Select(grupo => new
                {
                    VendedorId = grupo.Key,
                    TotalVentas = grupo.Sum(x => x.Total)
                })
                .OrderByDescending(x => x.TotalVentas)
                .ToList();

            chartVendedores.Series.Clear();
            var seriesVendedores = new Series
            {
                ChartType = SeriesChartType.Pie
            };

            foreach (var vendedor in vendedoresDestacados)
            {
                // Obtener el nombre del vendedor utilizando su UsuarioId
                var nombreVendedor = Usuarios.FirstOrDefault(u => u.Id == vendedor.VendedorId)?.Username ?? "Desconocido";

                var punto = seriesVendedores.Points.AddY(vendedor.TotalVentas);

                var datapoint = seriesVendedores.Points.Last();
                datapoint.Label = $"{vendedor.TotalVentas:C}";
                datapoint.LegendText = $"{nombreVendedor}"; // Mostrar el nombre del vendedor
            }

            chartVendedores.Series.Add(seriesVendedores);
            chartVendedores.Titles.Clear();
            chartVendedores.Titles.Add("Vendedores Destacados");
        }


        private async void CargarGraficoProductosMasVendidos()
        {
            await helper.GetAllProductos();
            await helper.GetAllPreventas();
            await helper.GetAllPreventaProductos();
            await helper.GetAllVentas();

            var Productos = helper.RetornarProductos();
            var Preventas = helper.RetornarPreventas();
            var PreventaProductos = helper.RetornarPreventaProductos();
            var Ventas = helper.RetornarVentas();

            // Agrupar por producto y calcular la cantidad total vendida por cada uno
            var productosMasVendidos = Preventas
                .Join(PreventaProductos,
                      preventa => preventa.Id,
                      preventaProducto => preventaProducto.PreventaId,
                      (preventa, preventaProducto) => new { preventa, preventaProducto })
                .Join(Productos,
                      pp => pp.preventaProducto.ProductoId,
                      producto => producto.Id,
                      (pp, producto) => new { pp.preventa, pp.preventaProducto, producto })
                .Join(Ventas,
                      ppv => ppv.preventa.Id,
                      venta => venta.PreventaId,
                      (ppv, venta) => new { ppv.preventa, ppv.preventaProducto, ppv.producto, venta })
                .GroupBy(item => item.producto.Nombre)
                .Select(grupo => new
                {
                    Producto = grupo.Key,
                    UnidadesVendidas = grupo.Sum(x => x.preventaProducto.Cantidad)
                })
                .OrderByDescending(x => x.UnidadesVendidas)
                .Take(10) // Puedes limitar a los top 10 productos más vendidos
                .ToList();

            // Limpiar series anteriores en el gráfico
            chartProductosMasVendidos.Series.Clear();

            // Crear la serie para el gráfico
            var seriesProductos = new Series
            {
                ChartType = SeriesChartType.Pie, // Utilizamos barras para mostrar los productos
                Name = "Productos Más Vendidos"
            };

            // Agregar los puntos al gráfico
            foreach (var producto in productosMasVendidos)
            {
                seriesProductos.Points.AddXY(producto.Producto, producto.UnidadesVendidas);
            }

            // Agregar la serie al gráfico
            chartProductosMasVendidos.Series.Add(seriesProductos);

            // Configurar título y etiquetas
            chartProductosMasVendidos.Titles.Clear();
            chartProductosMasVendidos.Titles.Add("Productos Más Vendidos");

            // Opcional: Configurar formato de los ejes
            chartProductosMasVendidos.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Inclinamos las etiquetas si es necesario
            chartProductosMasVendidos.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8); // Fuente más grande
            chartProductosMasVendidos.ChartAreas[0].AxisX.Interval = 1; // Cada barra representará un producto
        }




    }
}
