using MMForm.FormulariosData;
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

        private Form formActivo = null;
        private void OpenFormHijo(Form formHijo)
        {
            // Evitar cargar el mismo formulario varias veces
            if (formActivo != null && formActivo.GetType() == formHijo.GetType())
            {
                return; // Si ya está activo, no lo cargues de nuevo
            }

            if (formActivo != null)
            {
                formActivo.Close();
            }

            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            PnlFormHijo.Controls.Add(formHijo);
            formHijo.BringToFront();
            formHijo.Show();
        }



        #region Botones de ventana
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        #endregion


        private void btnResumen_Click(object sender, EventArgs e)
        {
            ResumenForm resumenForm = new ResumenForm();

            OpenFormHijo(resumenForm);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistorialForm historialForm = new HistorialForm();

            OpenFormHijo(historialForm);
        }
        private void PnlFormHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            Productos ProductosForm = new Productos();

            OpenFormHijo(ProductosForm);
        }
    }
}
