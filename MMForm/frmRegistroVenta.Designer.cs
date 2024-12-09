namespace MMForm
{
    partial class frmRegistroVenta
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnRegistarVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(838, 329);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 31);
            label1.Name = "label1";
            label1.Size = new Size(253, 38);
            label1.TabIndex = 1;
            label1.Text = "Registro de Ventas";
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackColor = Color.FromArgb(255, 146, 69);
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(255, 146, 69);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(626, 55);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(255, 146, 69);
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(255, 146, 69);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(737, 55);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnRegistarVenta
            // 
            btnRegistarVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistarVenta.BackColor = Color.FromArgb(255, 146, 69);
            btnRegistarVenta.FlatAppearance.BorderColor = Color.FromArgb(255, 146, 69);
            btnRegistarVenta.FlatStyle = FlatStyle.Flat;
            btnRegistarVenta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistarVenta.ForeColor = Color.White;
            btnRegistarVenta.Location = new Point(252, 453);
            btnRegistarVenta.Name = "btnRegistarVenta";
            btnRegistarVenta.Size = new Size(370, 60);
            btnRegistarVenta.TabIndex = 4;
            btnRegistarVenta.Text = "Registrar la venta";
            btnRegistarVenta.UseVisualStyleBackColor = false;
            // 
            // frmRegistroVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(129, 134, 139);
            ClientSize = new Size(862, 534);
            Controls.Add(btnRegistarVenta);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegistroVenta";
            Text = "frmRegistroVenta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnRegistarVenta;
    }
}