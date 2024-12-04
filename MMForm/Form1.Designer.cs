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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dgvPrueba = new DataGridView();
            btnPersonas = new Button();
            tcPrueba = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            flowLayoutPanelPrds = new FlowLayoutPanel();
            tabPage3 = new TabPage();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dgvPrueba).BeginInit();
            tcPrueba.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // dgvPrueba
            // 
            dgvPrueba.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrueba.Location = new Point(24, 50);
            dgvPrueba.Name = "dgvPrueba";
            dgvPrueba.RowHeadersWidth = 51;
            dgvPrueba.RowTemplate.Height = 29;
            dgvPrueba.Size = new Size(696, 212);
            dgvPrueba.TabIndex = 0;
            dgvPrueba.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnPersonas
            // 
            btnPersonas.Location = new Point(576, 409);
            btnPersonas.Name = "btnPersonas";
            btnPersonas.Size = new Size(94, 29);
            btnPersonas.TabIndex = 1;
            btnPersonas.Text = "cargar";
            btnPersonas.UseVisualStyleBackColor = true;
            btnPersonas.Click += btnPersonas_Click;
            // 
            // tcPrueba
            // 
            tcPrueba.Controls.Add(tabPage1);
            tcPrueba.Controls.Add(tabPage2);
            tcPrueba.Controls.Add(tabPage3);
            tcPrueba.Location = new Point(12, 12);
            tcPrueba.Name = "tcPrueba";
            tcPrueba.SelectedIndex = 0;
            tcPrueba.Size = new Size(785, 382);
            tcPrueba.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvPrueba);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(777, 349);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(flowLayoutPanelPrds);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(777, 349);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelPrds
            // 
            flowLayoutPanelPrds.BackColor = Color.DarkGray;
            flowLayoutPanelPrds.Location = new Point(6, 6);
            flowLayoutPanelPrds.Name = "flowLayoutPanelPrds";
            flowLayoutPanelPrds.Size = new Size(765, 337);
            flowLayoutPanelPrds.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(chart1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(777, 349);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(57, 25);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(305, 302);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcPrueba);
            Controls.Add(btnPersonas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPrueba).EndInit();
            tcPrueba.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPrueba;
        private Button btnPersonas;
        private TabControl tcPrueba;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private FlowLayoutPanel flowLayoutPanelPrds;
        private TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
