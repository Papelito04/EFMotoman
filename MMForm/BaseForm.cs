using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMForm
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        bool ProductoMenuExpand = false;
        private void Productotransition_Tick(object sender, EventArgs e)
        {
            if (ProductoMenuExpand == false)
            {
                prdContainer.Height += 5;
                if (prdContainer.Height >= 105)
                {
                    Productotransition.Stop();
                    ProductoMenuExpand = true;
                }
            }
            else
            {
                prdContainer.Height -= 5;
                if (prdContainer.Height <= 50)
                {
                    Productotransition.Stop();
                    ProductoMenuExpand = false;
                }
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productotransition.Start();
        }

        bool DetalleMenuExpand = false;
        private void DetalleTransition_Tick(object sender, EventArgs e)
        {
            if (DetalleMenuExpand == false)
            {
                DetalleContainer.Height += 5;
                if (DetalleContainer.Height >= 203)
                {
                    DetalleTransition.Stop();
                    DetalleMenuExpand = true;
                }
            }
            else
            {
                DetalleContainer.Height -= 5;
                if (DetalleContainer.Height <= 50)
                {
                    DetalleTransition.Stop();
                    DetalleMenuExpand = false;
                }
            }
        }

        private void btnDetallesVentas_Click(object sender, EventArgs e)
        {

            DetalleTransition.Start();
        }

        bool NavBarMenuExpand = true;
        private void NavBartransition_Tick(object sender, EventArgs e)
        {
            if (NavBarMenuExpand)
            {
                flpNavBar.Width -= 5;
                if (flpNavBar.Width <= 50)
                {
                    NavBarMenuExpand = false;
                    NavBartransition.Stop();

                    //QUIZAS LUEGO PONER QUE LOS PANELES = NAVBAR.WITH
                }
            }
            else
            {
                flpNavBar.Width += 5;
                if (flpNavBar.Width >= 240)
                {
                    NavBarMenuExpand = true;
                    NavBartransition.Stop();

                    //QUIZAS LUEGO PONER QUE LOS PANELES = NAVBAR.WITH
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            NavBartransition.Start();
        } 
    }
}
