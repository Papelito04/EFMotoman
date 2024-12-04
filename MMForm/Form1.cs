using MMForm.UserControles;

namespace MMForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        Helpers helper = new Helpers();
        private async void btnPersonas_Click(object sender, EventArgs e)
        {
            await helper.GetAllProductos();

            
            dgvPrueba.DataSource = helper.RetornarProductos();
            CargarProductosFlowLayout();

        }

        private void CargarProductosFlowLayout()
        {
            
            var listaProductos = helper.RetornarProductos();  

            // Limpiar el FlowLayoutPanel antes de agregar nuevos controles
            flowLayoutPanelPrds.Controls.Clear();

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
                flowLayoutPanelPrds.Controls.Add(productoControl);
            }
        }

    }
}
