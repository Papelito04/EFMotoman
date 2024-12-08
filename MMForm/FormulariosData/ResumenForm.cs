using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MMForm.FormulariosData
{
    public partial class ResumenForm : Form
    {
        public ResumenForm()
        {
            InitializeComponent();
        }


        Helpers helper = new Helpers();
        private async void ResumenForm_Load(object sender, EventArgs e)
        {

            lblFecha.Text =$"Fecha: {DateTime.Now}";
            await helper.GetAllProductos();
            await helper.GetAllPreventas();
            await helper.GetAllPreventaProductos();

            var Productos = helper.RetornarProductos();
            var Preventas = helper.RetornarPreventas();
            var PreventaProductos = helper.RetornarPreventaProductos();

            var resumen = Preventas
            .Where(preventa => preventa.Fecha.Date == DateTime.Today) // Filtro para solo el día de hoy
            .Join(PreventaProductos,
                  preventa => preventa.Id,
                  preventaProducto => preventaProducto.PreventaId,
                  (preventa, preventaProducto) => new
                  {
                      Hora = preventa.Fecha.Hour, // Extrae la hora de fecha
                      preventaProducto.ProductoId,
                      preventaProducto.Cantidad
                  })
            .Join(Productos,
                  pp => pp.ProductoId,
                  producto => producto.Id,
                  (pp, producto) => new
                  {
                      pp.Hora,
                      pp.Cantidad,
                      producto.Nombre,
                      producto.PrecioVenta
                  })
            .GroupBy(item => item.Hora)
            .Select(grupo => new
            {
                Hora = grupo.Key,
                UnidadesVendidas = grupo.Sum(x => x.Cantidad),
                ProductoMasVendido = grupo.GroupBy(x => x.Nombre)
                                          .OrderByDescending(x => x.Sum(p => p.Cantidad))
                                          .FirstOrDefault()?.Key, // Producto más vendido
                VentaNeta = grupo.Sum(x => x.Cantidad * x.PrecioVenta) // Suma total de ventas
            })
            .OrderBy(resumen => resumen.Hora)
            .ToList();

            dgvResumen.DataSource = resumen;




            var productos = new List<(string producto, int cantidad)>
            {
                ("Cámara", 10),
                ("Holder", 5),
                ("Tripode", 7)
            };





            var resumenProductos = Preventas
       .Where(preventa => preventa.Fecha.Date == DateTime.Today) // Filtrar por día actual
       .Join(PreventaProductos,
             preventa => preventa.Id,
             preventaProducto => preventaProducto.PreventaId,
             (preventa, preventaProducto) => preventaProducto)
       .GroupBy(preventaProducto => preventaProducto.ProductoId)
       .Select(grupo => new
       {
           ProductoId = grupo.Key,
           TotalVendidas = grupo.Sum(p => p.Cantidad)
       })
       .Join(Productos,
             resumen => resumen.ProductoId,
             producto => producto.Id,
             (resumen, producto) => new
             {
                 ProductoNombre = producto.Nombre,
                 TotalVendidas = resumen.TotalVendidas
             })
       .ToList();


            var productosGrafico = resumenProductos
        .Select(r => (r.ProductoNombre, r.TotalVendidas))
        .ToList();




            // Llamar a la función para graficar productos
            GraficarProductos(productosGrafico);




            var resumenProductosDinero = Preventas
    .Where(preventa => preventa.Fecha.Date == DateTime.Today) 
    .Join(PreventaProductos,
          preventa => preventa.Id,
          preventaProducto => preventaProducto.PreventaId,
          (preventa, preventaProducto) => preventaProducto)
    .GroupBy(preventaProducto => preventaProducto.ProductoId)
    .Select(grupo => new
    {
        ProductoId = grupo.Key,
        TotalCantidad = grupo.Sum(p => p.Cantidad)
    })
    .Join(Productos,
          resumen => resumen.ProductoId,
          producto => producto.Id,
          (resumen, producto) => new
          {
              ProductoNombre = producto.Nombre,
              TotalDinero = resumen.TotalCantidad * producto.PrecioVenta // Calcular total en dinero
          })
    .ToList();


            var productosConDinero = resumenProductosDinero
    .Select(r => (r.ProductoNombre, r.TotalDinero))
    .ToList();


            GraficarPorcentajesDineroProductos(productosConDinero);

        }

        private void GraficarProductos(List<(string producto, int cantidad)> productos)
        {
            // Limpia configuraciones previas
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Titles.Clear();

            // Crea una nueva área de gráfico
            var chartArea = new ChartArea
            {
                AxisX = { Title = "Productos", Interval = 1 },
                AxisY = { Title = "Cantidad Vendida" }
            };
            chart1.ChartAreas.Add(chartArea);

            // Crea una serie para el gráfico
            var series = new Series
            {
                Name="Ventas",
                ChartType = SeriesChartType.Column, // Tipo de gráfico: columnas
                IsValueShownAsLabel = true          // Mostrar valores en las barras
            };

            // Genera un índice para cada producto
            var productosConIndices = productos.Select((p, i) => (indice: i + 1, p.producto, p.cantidad)).ToList();

            // Agrega los datos a la serie usando los índices
            foreach (var producto in productosConIndices)
            {
                var punto = series.Points.AddXY(producto.indice, producto.cantidad);
                var dataPoint = series.Points.Last(); // Obtiene el último punto añadido
                dataPoint.AxisLabel = producto.producto; // Etiqueta del eje X correspondiente al producto
                dataPoint.Label = $"{producto.cantidad}"; // Etiqueta en la barra mostrando la cantidad
            }

            // Añade la serie al gráfico
            chart1.Series.Add(series);

            // Configura las etiquetas del eje X
            chartArea.AxisX.CustomLabels.Clear();
            foreach (var producto in productosConIndices)
            {
                var label = new CustomLabel
                {
                    FromPosition = producto.indice - 0.5,
                    ToPosition = producto.indice + 0.5,
                    Text = producto.producto
                };
                chartArea.AxisX.CustomLabels.Add(label);
            }

            // Añade un título al gráfico
            chart1.Titles.Add("Ventas por Producto Hoy");
        }


        private void GraficarPorcentajesDineroProductos(List<(string producto, double totalVentas)> productos)
        {
            // Limpia configuraciones previas
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();
            chart2.Titles.Clear();

            // Calcula el total de dinero vendido
            var totalDinero = productos.Sum(p => p.totalVentas);

            // Crea una nueva área de gráfico
            var chartArea = new ChartArea();
            chart2.ChartAreas.Add(chartArea);

            // Crea una serie para el gráfico de pastel
            var series = new Series
            {
                ChartType = SeriesChartType.Pie, // Tipo de gráfico: pastel
                IsValueShownAsLabel = true       // Mostrar valores en las secciones
            };

            // Agrega los datos a la serie
            foreach (var producto in productos)
            {
                var porcentaje = (producto.totalVentas / totalDinero) * 100;
                var punto = series.Points.AddXY(producto.producto, producto.totalVentas);

                var datapoint = series.Points.Last();
                datapoint.Label = $"{porcentaje:F1}%"; // Mostrar el porcentaje en el gráfico
                datapoint.LegendText = $"{producto.producto}: (${producto.totalVentas:F2})"; // Mostrar solo el nombre del producto en la leyenda
                datapoint.ToolTip = $"Ventas totales: ${producto.totalVentas:F2}"; // Información adicional al pasar el mouse
            }


            // Añade la serie al gráfico
            chart2.Series.Add(series);

            // Añade un título al gráfico
            chart2.Titles.Add("Distribución de Ventas por Producto (En Dinero)");
        }


        /*
        private void GraficarProductos(List<(string producto, int cantidad)> productos)
        {
            // Limpiar series existentes en el gráfico
            chart1.Series.Clear();

            // Crear una nueva serie para el gráfico de pastel
            var series = new Series
            {
                ChartType = SeriesChartType.Pie, // Tipo de gráfico de pastel
                IsValueShownAsLabel = true // Mostrar etiquetas con los valores
            };

            // Agregar los datos a la serie
            foreach (var producto in productos)
            {
                series.Points.AddXY(producto.producto, producto.cantidad);
            }

            // Configurar etiquetas para cada punto
            foreach (var point in series.Points)
            {
                point.Label = $"{point.AxisLabel}: {point.YValues[0]}"; // Etiqueta con nombre y cantidad
            }

            // Añadir la serie al gráfico
            chart1.Series.Add(series);

            // Añadir un título al gráfico
            chart1.Titles.Clear();
            chart1.Titles.Add("Ventas por Producto Hoy");
        }
        */



    }
}
