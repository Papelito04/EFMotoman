namespace MMForm
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            pnlBarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnSalir = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMenu = new PictureBox();
            flpNavBar = new FlowLayoutPanel();
            prdContainer = new FlowLayoutPanel();
            pnlProductos = new Panel();
            btnProductos = new Button();
            pnlCatalogo = new Panel();
            btnCatalogo = new Button();
            DetalleContainer = new FlowLayoutPanel();
            pnlDetallesVentas = new Panel();
            btnDetallesVentas = new Button();
            pnlResgistrarVenta = new Panel();
            btnRegistrarVenta = new Button();
            pnlResumen = new Panel();
            btnResumen = new Button();
            pnlHistorial = new Panel();
            btnHistorial = new Button();
            pnlCuenta = new Panel();
            btnCuenta = new Button();
            pnlCerrarSesion = new Panel();
            btnCerrarSesion = new Button();
            Productotransition = new System.Windows.Forms.Timer(components);
            DetalleTransition = new System.Windows.Forms.Timer(components);
            NavBartransition = new System.Windows.Forms.Timer(components);
            pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            flpNavBar.SuspendLayout();
            prdContainer.SuspendLayout();
            pnlProductos.SuspendLayout();
            pnlCatalogo.SuspendLayout();
            DetalleContainer.SuspendLayout();
            pnlDetallesVentas.SuspendLayout();
            pnlResgistrarVenta.SuspendLayout();
            pnlResumen.SuspendLayout();
            pnlHistorial.SuspendLayout();
            pnlCuenta.SuspendLayout();
            pnlCerrarSesion.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            pnlBarraTitulo.BackColor = Color.White;
            pnlBarraTitulo.Controls.Add(btnRestaurar);
            pnlBarraTitulo.Controls.Add(btnSalir);
            pnlBarraTitulo.Controls.Add(btnMinimizar);
            pnlBarraTitulo.Controls.Add(btnMaximizar);
            pnlBarraTitulo.Controls.Add(btnMenu);
            pnlBarraTitulo.Dock = DockStyle.Top;
            pnlBarraTitulo.Location = new Point(0, 0);
            pnlBarraTitulo.Name = "pnlBarraTitulo";
            pnlBarraTitulo.Size = new Size(1130, 39);
            pnlBarraTitulo.TabIndex = 0;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(972, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(32, 33);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(1086, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(32, 33);
            btnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnSalir.TabIndex = 4;
            btnSalir.TabStop = false;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1010, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(32, 33);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1048, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(32, 33);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 2;
            btnMaximizar.TabStop = false;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(12, 6);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(35, 29);
            btnMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMenu.TabIndex = 1;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // flpNavBar
            // 
            flpNavBar.BackColor = Color.FromArgb(255, 146, 69);
            flpNavBar.Controls.Add(prdContainer);
            flpNavBar.Controls.Add(DetalleContainer);
            flpNavBar.Controls.Add(pnlCuenta);
            flpNavBar.Controls.Add(pnlCerrarSesion);
            flpNavBar.Dock = DockStyle.Left;
            flpNavBar.FlowDirection = FlowDirection.TopDown;
            flpNavBar.Location = new Point(0, 39);
            flpNavBar.Name = "flpNavBar";
            flpNavBar.Size = new Size(240, 581);
            flpNavBar.TabIndex = 1;
            // 
            // prdContainer
            // 
            prdContainer.BackColor = Color.FromArgb(255, 146, 69);
            prdContainer.Controls.Add(pnlProductos);
            prdContainer.Controls.Add(pnlCatalogo);
            prdContainer.Location = new Point(0, 0);
            prdContainer.Margin = new Padding(0);
            prdContainer.Name = "prdContainer";
            prdContainer.Size = new Size(255, 50);
            prdContainer.TabIndex = 5;
            // 
            // pnlProductos
            // 
            pnlProductos.Controls.Add(btnProductos);
            pnlProductos.Location = new Point(3, 3);
            pnlProductos.Name = "pnlProductos";
            pnlProductos.Size = new Size(252, 50);
            pnlProductos.TabIndex = 2;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(255, 146, 69);
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.FromArgb(223, 214, 214);
            btnProductos.Location = new Point(-15, -9);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(286, 68);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // pnlCatalogo
            // 
            pnlCatalogo.Controls.Add(btnCatalogo);
            pnlCatalogo.Location = new Point(0, 56);
            pnlCatalogo.Margin = new Padding(0);
            pnlCatalogo.Name = "pnlCatalogo";
            pnlCatalogo.Size = new Size(255, 50);
            pnlCatalogo.TabIndex = 4;
            // 
            // btnCatalogo
            // 
            btnCatalogo.BackColor = Color.FromArgb(227, 130, 61);
            btnCatalogo.Cursor = Cursors.Hand;
            btnCatalogo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCatalogo.ForeColor = Color.FromArgb(223, 214, 214);
            btnCatalogo.Location = new Point(-15, -9);
            btnCatalogo.Name = "btnCatalogo";
            btnCatalogo.Size = new Size(289, 68);
            btnCatalogo.TabIndex = 0;
            btnCatalogo.Text = "Catalogo";
            btnCatalogo.UseVisualStyleBackColor = false;
            // 
            // DetalleContainer
            // 
            DetalleContainer.BackColor = Color.FromArgb(255, 146, 69);
            DetalleContainer.Controls.Add(pnlDetallesVentas);
            DetalleContainer.Controls.Add(pnlResgistrarVenta);
            DetalleContainer.Controls.Add(pnlResumen);
            DetalleContainer.Controls.Add(pnlHistorial);
            DetalleContainer.Location = new Point(0, 50);
            DetalleContainer.Margin = new Padding(0);
            DetalleContainer.Name = "DetalleContainer";
            DetalleContainer.Size = new Size(255, 50);
            DetalleContainer.TabIndex = 6;
            // 
            // pnlDetallesVentas
            // 
            pnlDetallesVentas.Controls.Add(btnDetallesVentas);
            pnlDetallesVentas.Location = new Point(3, 3);
            pnlDetallesVentas.Name = "pnlDetallesVentas";
            pnlDetallesVentas.Size = new Size(252, 50);
            pnlDetallesVentas.TabIndex = 3;
            // 
            // btnDetallesVentas
            // 
            btnDetallesVentas.BackColor = Color.FromArgb(255, 146, 69);
            btnDetallesVentas.Cursor = Cursors.Hand;
            btnDetallesVentas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDetallesVentas.ForeColor = Color.FromArgb(223, 214, 214);
            btnDetallesVentas.Location = new Point(-15, -9);
            btnDetallesVentas.Name = "btnDetallesVentas";
            btnDetallesVentas.Size = new Size(289, 68);
            btnDetallesVentas.TabIndex = 0;
            btnDetallesVentas.Text = "Detalles de Venta";
            btnDetallesVentas.UseVisualStyleBackColor = false;
            btnDetallesVentas.Click += btnDetallesVentas_Click;
            // 
            // pnlResgistrarVenta
            // 
            pnlResgistrarVenta.Controls.Add(btnRegistrarVenta);
            pnlResgistrarVenta.Location = new Point(0, 56);
            pnlResgistrarVenta.Margin = new Padding(0);
            pnlResgistrarVenta.Name = "pnlResgistrarVenta";
            pnlResgistrarVenta.Size = new Size(255, 50);
            pnlResgistrarVenta.TabIndex = 4;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.BackColor = Color.FromArgb(227, 130, 61);
            btnRegistrarVenta.Cursor = Cursors.Hand;
            btnRegistrarVenta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarVenta.ForeColor = Color.FromArgb(223, 214, 214);
            btnRegistrarVenta.Location = new Point(-15, -9);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(289, 68);
            btnRegistrarVenta.TabIndex = 0;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = false;
            // 
            // pnlResumen
            // 
            pnlResumen.Controls.Add(btnResumen);
            pnlResumen.Location = new Point(0, 106);
            pnlResumen.Margin = new Padding(0);
            pnlResumen.Name = "pnlResumen";
            pnlResumen.Size = new Size(255, 50);
            pnlResumen.TabIndex = 5;
            // 
            // btnResumen
            // 
            btnResumen.BackColor = Color.FromArgb(227, 130, 61);
            btnResumen.Cursor = Cursors.Hand;
            btnResumen.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnResumen.ForeColor = Color.FromArgb(223, 214, 214);
            btnResumen.Location = new Point(-15, -9);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(289, 68);
            btnResumen.TabIndex = 0;
            btnResumen.Text = "Resumen";
            btnResumen.UseVisualStyleBackColor = false;
            // 
            // pnlHistorial
            // 
            pnlHistorial.Controls.Add(btnHistorial);
            pnlHistorial.Location = new Point(0, 156);
            pnlHistorial.Margin = new Padding(0);
            pnlHistorial.Name = "pnlHistorial";
            pnlHistorial.Size = new Size(255, 50);
            pnlHistorial.TabIndex = 6;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(227, 130, 61);
            btnHistorial.Cursor = Cursors.Hand;
            btnHistorial.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistorial.ForeColor = Color.FromArgb(223, 214, 214);
            btnHistorial.Location = new Point(-15, -9);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(289, 68);
            btnHistorial.TabIndex = 0;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = false;
            // 
            // pnlCuenta
            // 
            pnlCuenta.Controls.Add(btnCuenta);
            pnlCuenta.Location = new Point(0, 100);
            pnlCuenta.Margin = new Padding(0);
            pnlCuenta.Name = "pnlCuenta";
            pnlCuenta.Size = new Size(255, 50);
            pnlCuenta.TabIndex = 3;
            // 
            // btnCuenta
            // 
            btnCuenta.BackColor = Color.FromArgb(255, 146, 69);
            btnCuenta.Cursor = Cursors.Hand;
            btnCuenta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCuenta.ForeColor = Color.FromArgb(223, 214, 214);
            btnCuenta.Location = new Point(-15, -9);
            btnCuenta.Name = "btnCuenta";
            btnCuenta.Size = new Size(292, 68);
            btnCuenta.TabIndex = 0;
            btnCuenta.Text = "Cuenta";
            btnCuenta.UseVisualStyleBackColor = false;
            // 
            // pnlCerrarSesion
            // 
            pnlCerrarSesion.Controls.Add(btnCerrarSesion);
            pnlCerrarSesion.Location = new Point(0, 150);
            pnlCerrarSesion.Margin = new Padding(0);
            pnlCerrarSesion.Name = "pnlCerrarSesion";
            pnlCerrarSesion.Size = new Size(255, 50);
            pnlCerrarSesion.TabIndex = 4;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(255, 146, 69);
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.FromArgb(223, 214, 214);
            btnCerrarSesion.Location = new Point(-15, -9);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(292, 68);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // Productotransition
            // 
            Productotransition.Interval = 5;
            Productotransition.Tick += Productotransition_Tick;
            // 
            // DetalleTransition
            // 
            DetalleTransition.Interval = 5;
            DetalleTransition.Tick += DetalleTransition_Tick;
            // 
            // NavBartransition
            // 
            NavBartransition.Interval = 5;
            NavBartransition.Tick += NavBartransition_Tick;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 620);
            Controls.Add(flpNavBar);
            Controls.Add(pnlBarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "BaseForm";
            Text = "BaseForm";
            pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            flpNavBar.ResumeLayout(false);
            prdContainer.ResumeLayout(false);
            pnlProductos.ResumeLayout(false);
            pnlCatalogo.ResumeLayout(false);
            DetalleContainer.ResumeLayout(false);
            pnlDetallesVentas.ResumeLayout(false);
            pnlResgistrarVenta.ResumeLayout(false);
            pnlResumen.ResumeLayout(false);
            pnlHistorial.ResumeLayout(false);
            pnlCuenta.ResumeLayout(false);
            pnlCerrarSesion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBarraTitulo;
        private PictureBox btnMenu;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox btnSalir;
        private FlowLayoutPanel flpNavBar;
        private Panel pnlProductos;
        private Button btnProductos;
        private Panel pnlDetallesVentas;
        private Button btnDetallesVentas;
        private Panel pnlCuenta;
        private Button btnCuenta;
        private Panel pnlCerrarSesion;
        private Button btnCerrarSesion;
        private FlowLayoutPanel prdContainer;
        private Panel pnlCatalogo;
        private Button btnCatalogo;
        private Panel pnlResgistrarVenta;
        private Button btnRegistrarVenta;
        private FlowLayoutPanel DetalleContainer;
        private Panel pnlResumen;
        private Button btnResumen;
        private Panel pnlHistorial;
        private Button btnHistorial;
        private System.Windows.Forms.Timer Productotransition;
        private System.Windows.Forms.Timer DetalleTransition;
        private System.Windows.Forms.Timer NavBartransition;
    }
}