using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFMotoman.Models.Dto;
using MMForm;
using MMForm.UserControles;


namespace MMForm
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        Helpers helper = new Helpers();

        private void Productos_Load(object sender, EventArgs e)
        {
            List<EFMotoman.Models.Dto.CategoriaDto> listaCategorias = new List<EFMotoman.Models.Dto.CategoriaDto>();
            cmbxBusqueda.DataSource = listaCategorias;
            cmbxBusqueda.DisplayMember = "Nombre"; // Lo que se muestra al usuario
            cmbxBusqueda.ValueMember = "Id";      // Valor interno (clave única)

            //carrusel de productos
            
            
            helper.GetAllProductos();

            CargarProductosFlowLayout();
                     
                     
        }

        private void CargarProductosFlowLayout()
        {

            var listaProductos = helper.RetornarProductos();

            // Limpiar el FlowLayoutPanel antes de agregar nuevos controles
            flytpnlMostrarProductos.Controls.Clear();

            // Iterar sobre la lista de productos
            foreach (var productoDTO in listaProductos)
            {
                // Crear una nueva instancia de ProductoControl para cada producto
                ProductControl productoControl = new ProductControl
                {
                    NombreProducto = productoDTO.Nombre,
                    Precio = $"${productoDTO.PrecioVenta}"
                };

                // Agregar el control al FlowLayoutPanel
                flytpnlMostrarProductos.Controls.Add(productoControl);
            }
        }

        private void cmbxBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void flytpnlMostrarProductos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
