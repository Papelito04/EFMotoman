namespace MMForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPrueba = new DataGridView();
            btnPersonas = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrueba).BeginInit();
            SuspendLayout();
            // 
            // dgvPrueba
            // 
            dgvPrueba.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrueba.Location = new Point(34, 12);
            dgvPrueba.Name = "dgvPrueba";
            dgvPrueba.RowHeadersWidth = 51;
            dgvPrueba.RowTemplate.Height = 29;
            dgvPrueba.Size = new Size(723, 293);
            dgvPrueba.TabIndex = 0;
            dgvPrueba.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnPersonas
            // 
            btnPersonas.Location = new Point(457, 387);
            btnPersonas.Name = "btnPersonas";
            btnPersonas.Size = new Size(94, 29);
            btnPersonas.TabIndex = 1;
            btnPersonas.Text = "cargar";
            btnPersonas.UseVisualStyleBackColor = true;
            btnPersonas.Click += btnPersonas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPersonas);
            Controls.Add(dgvPrueba);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPrueba).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPrueba;
        private Button btnPersonas;
    }
}
