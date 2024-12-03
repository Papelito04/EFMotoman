using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMForm.UserControles
{
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
        }

        // Propiedad para establecer el nombre del producto
        public string NombreProducto
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }

        // Propiedad para establecer el precio
        public string Precio
        {
            get { return lblPrecio.Text; }
            set { lblPrecio.Text = value; }
        }
    }
}
