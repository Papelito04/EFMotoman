namespace MMForm.UserControles
{
    partial class ProductControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            button1 = new Button();
            pbImagenProduct = new PictureBox();
            lblPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImagenProduct).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(96, 160);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(50, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(75, 248);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // pbImagenProduct
            // 
            pbImagenProduct.Location = new Point(51, 17);
            pbImagenProduct.Name = "pbImagenProduct";
            pbImagenProduct.Size = new Size(139, 101);
            pbImagenProduct.TabIndex = 3;
            pbImagenProduct.TabStop = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(99, 204);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "label1";
            // 
            // ProductControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblPrecio);
            Controls.Add(pbImagenProduct);
            Controls.Add(button1);
            Controls.Add(lblNombre);
            Name = "ProductControl";
            Size = new Size(247, 319);
            ((System.ComponentModel.ISupportInitialize)pbImagenProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Button button1;
        private PictureBox pbImagenProduct;
        private Label lblPrecio;
    }
}
