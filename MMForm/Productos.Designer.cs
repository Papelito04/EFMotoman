namespace MMForm
{
    partial class Productos
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
            cmbxBusqueda = new ComboBox();
            flytpnlMostrarProductos = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // cmbxBusqueda
            // 
            cmbxBusqueda.FormattingEnabled = true;
            cmbxBusqueda.Location = new Point(106, 24);
            cmbxBusqueda.Name = "cmbxBusqueda";
            cmbxBusqueda.Size = new Size(644, 28);
            cmbxBusqueda.TabIndex = 0;
            cmbxBusqueda.SelectedIndexChanged += cmbxBusqueda_SelectedIndexChanged;
            // 
            // flytpnlMostrarProductos
            // 
            flytpnlMostrarProductos.BackColor = Color.Transparent;
            flytpnlMostrarProductos.Location = new Point(28, 58);
            flytpnlMostrarProductos.Name = "flytpnlMostrarProductos";
            flytpnlMostrarProductos.Size = new Size(800, 445);
            flytpnlMostrarProductos.TabIndex = 1;
            flytpnlMostrarProductos.Paint += flytpnlMostrarProductos_Paint;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(872, 534);
            Controls.Add(flytpnlMostrarProductos);
            Controls.Add(cmbxBusqueda);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbxBusqueda;
        private FlowLayoutPanel flytpnlMostrarProductos;
    }
}