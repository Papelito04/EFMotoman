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
            Productotransition = new System.Windows.Forms.Timer(components);
            DetalleTransition = new System.Windows.Forms.Timer(components);
            NavBartransition = new System.Windows.Forms.Timer(components);
            flpNavBar = new Panel();
            btnProductos = new Button();
            pnlCatalogo = new Panel();
            btnCatalogo = new Button();
            btnDetallesVentas = new Button();
            pnlDetallesVentas = new Panel();
            btnRegistrarVenta = new Button();
            btnResumen = new Button();
            btnHistorial = new Button();
            btnCuenta = new Button();
            btnCerrarSesion = new Button();
            PnlFormHijo = new Panel();
            panel1 = new Panel();
            pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            flpNavBar.SuspendLayout();
            pnlCatalogo.SuspendLayout();
            pnlDetallesVentas.SuspendLayout();
            PnlFormHijo.SuspendLayout();
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
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1048, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(32, 33);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(1086, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(32, 33);
            btnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnSalir.TabIndex = 4;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1010, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(32, 33);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1048, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(32, 33);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 2;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
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
            // Productotransition
            // 
            Productotransition.Interval = 2;
            Productotransition.Tick += Productotransition_Tick;
            // 
            // DetalleTransition
            // 
            DetalleTransition.Interval = 2;
            DetalleTransition.Tick += DetalleTransition_Tick;
            // 
            // NavBartransition
            // 
            NavBartransition.Interval = 2;
            NavBartransition.Tick += NavBartransition_Tick;
            // 
            // flpNavBar
            // 
            flpNavBar.AutoScroll = true;
            flpNavBar.BackColor = Color.FromArgb(255, 146, 69);
            flpNavBar.Controls.Add(btnCerrarSesion);
            flpNavBar.Controls.Add(btnCuenta);
            flpNavBar.Controls.Add(pnlDetallesVentas);
            flpNavBar.Controls.Add(btnDetallesVentas);
            flpNavBar.Controls.Add(pnlCatalogo);
            flpNavBar.Controls.Add(btnProductos);
            flpNavBar.Dock = DockStyle.Left;
            flpNavBar.Location = new Point(0, 0);
            flpNavBar.Name = "flpNavBar";
            flpNavBar.Size = new Size(250, 581);
            flpNavBar.TabIndex = 5;
            flpNavBar.Paint += panel1_Paint;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(255, 146, 69);
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatAppearance.BorderColor = Color.FromArgb(255, 146, 69);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(0, 0);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(250, 68);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // pnlCatalogo
            // 
            pnlCatalogo.Controls.Add(btnCatalogo);
            pnlCatalogo.Dock = DockStyle.Top;
            pnlCatalogo.Location = new Point(0, 68);
            pnlCatalogo.Name = "pnlCatalogo";
            pnlCatalogo.Size = new Size(250, 76);
            pnlCatalogo.TabIndex = 1;
            // 
            // btnCatalogo
            // 
            btnCatalogo.BackColor = Color.FromArgb(255, 146, 69);
            btnCatalogo.Cursor = Cursors.Hand;
            btnCatalogo.Dock = DockStyle.Top;
            btnCatalogo.FlatAppearance.BorderColor = Color.FromArgb(255, 146, 69);
            btnCatalogo.FlatStyle = FlatStyle.Flat;
            btnCatalogo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCatalogo.ForeColor = Color.FromArgb(223, 214, 214);
            btnCatalogo.Location = new Point(0, 0);
            btnCatalogo.Name = "btnCatalogo";
            btnCatalogo.Size = new Size(250, 68);
            btnCatalogo.TabIndex = 0;
            btnCatalogo.Text = "Catalogo";
            btnCatalogo.UseVisualStyleBackColor = false;
            // 
            // btnDetallesVentas
            // 
            btnDetallesVentas.BackColor = Color.FromArgb(255, 146, 69);
            btnDetallesVentas.Dock = DockStyle.Top;
            btnDetallesVentas.FlatAppearance.BorderColor = Color.FromArgb(255, 146, 69);
            btnDetallesVentas.FlatStyle = FlatStyle.Flat;
            btnDetallesVentas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDetallesVentas.ForeColor = Color.White;
            btnDetallesVentas.Location = new Point(0, 144);
            btnDetallesVentas.Name = "btnDetallesVentas";
            btnDetallesVentas.Size = new Size(250, 68);
            btnDetallesVentas.TabIndex = 2;
            btnDetallesVentas.Text = "Venta";
            btnDetallesVentas.UseVisualStyleBackColor = false;
            btnDetallesVentas.Click += btnDetallesVentas_Click;
            // 
            // pnlDetallesVentas
            // 
            pnlDetallesVentas.Controls.Add(btnHistorial);
            pnlDetallesVentas.Controls.Add(btnResumen);
            pnlDetallesVentas.Controls.Add(btnRegistrarVenta);
            pnlDetallesVentas.Dock = DockStyle.Top;
            pnlDetallesVentas.Location = new Point(0, 212);
            pnlDetallesVentas.Name = "pnlDetallesVentas";
            pnlDetallesVentas.Size = new Size(250, 212);
            pnlDetallesVentas.TabIndex = 3;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.BackColor = Color.FromArgb(255, 146, 69);
            btnRegistrarVenta.Dock = DockStyle.Top;
            btnRegistrarVenta.FlatAppearance.BorderColor = Color.FromArgb(255, 146, 69);
            btnRegistrarVenta.FlatStyle = FlatStyle.Flat;
            btnRegistrarVenta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarVenta.ForeColor = Color.FromArgb(223, 214, 214);
            btnRegistrarVenta.Location = new Point(0, 0);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(250, 68);
            btnRegistrarVenta.TabIndex = 0;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = false;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click_1;
            // 
            // btnResumen
            // 
            btnResumen.BackColor = Color.FromArgb(255, 146, 69);
            btnResumen.Dock = DockStyle.Top;
            btnResumen.FlatAppearance.BorderColor = Color.FromArgb(255, 146, 69);
            btnResumen.FlatStyle = FlatStyle.Flat;
            btnResumen.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnResumen.ForeColor = Color.FromArgb(223, 214, 214);
            btnResumen.Location = new Point(0, 68);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(250, 68);
            btnResumen.TabIndex = 1;
            btnResumen.Text = "Resumen";
            btnResumen.UseVisualStyleBackColor = false;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(255, 146, 69);
            btnHistorial.Dock = DockStyle.Top;
            btnHistorial.FlatAppearance.BorderColor = Color.FromArgb(255, 146, 69);
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistorial.ForeColor = Color.FromArgb(223, 214, 214);
            btnHistorial.Location = new Point(0, 136);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(250, 68);
            btnHistorial.TabIndex = 2;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = false;
            // 
            // btnCuenta
            // 
            btnCuenta.BackColor = Color.FromArgb(255, 146, 69);
            btnCuenta.Dock = DockStyle.Top;
            btnCuenta.FlatAppearance.BorderColor = Color.FromArgb(255, 146, 69);
            btnCuenta.FlatStyle = FlatStyle.Flat;
            btnCuenta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCuenta.ForeColor = Color.White;
            btnCuenta.Location = new Point(0, 424);
            btnCuenta.Name = "btnCuenta";
            btnCuenta.Size = new Size(250, 68);
            btnCuenta.TabIndex = 4;
            btnCuenta.Text = "Cuenta";
            btnCuenta.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(255, 146, 69);
            btnCerrarSesion.Dock = DockStyle.Top;
            btnCerrarSesion.FlatAppearance.BorderColor = Color.FromArgb(255, 146, 69);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(0, 492);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(250, 68);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // PnlFormHijo
            // 
            PnlFormHijo.BackColor = Color.FromArgb(129, 134, 139);
            PnlFormHijo.Controls.Add(panel1);
            PnlFormHijo.Controls.Add(flpNavBar);
            PnlFormHijo.Dock = DockStyle.Fill;
            PnlFormHijo.Location = new Point(0, 39);
            PnlFormHijo.Name = "PnlFormHijo";
            PnlFormHijo.Size = new Size(1130, 581);
            PnlFormHijo.TabIndex = 2;
            PnlFormHijo.Paint += PnlFormHijo_Paint;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 581);
            panel1.TabIndex = 6;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 620);
            Controls.Add(PnlFormHijo);
            Controls.Add(pnlBarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaseForm";
            Text = "BaseForm";
            pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            flpNavBar.ResumeLayout(false);
            pnlCatalogo.ResumeLayout(false);
            pnlDetallesVentas.ResumeLayout(false);
            PnlFormHijo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBarraTitulo;
        private PictureBox btnMenu;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox btnSalir;
        private System.Windows.Forms.Timer Productotransition;
        private System.Windows.Forms.Timer DetalleTransition;
        private System.Windows.Forms.Timer NavBartransition;
        private Panel flpNavBar;
        private Button btnCerrarSesion;
        private Button btnCuenta;
        private Panel pnlDetallesVentas;
        private Button btnHistorial;
        private Button btnResumen;
        private Button btnRegistrarVenta;
        private Button btnDetallesVentas;
        private Panel pnlCatalogo;
        private Button btnCatalogo;
        private Button btnProductos;
        private Panel PnlFormHijo;
        private Panel panel1;
    }
}