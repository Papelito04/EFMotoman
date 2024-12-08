namespace MMForm.FormulariosData
{
    partial class HistorialForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dataGridView1 = new DataGridView();
            lblTitle = new Label();
            chartIngresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartGanancias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartVendedores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartProductosMasVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartIngresos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartGanancias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartVendedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartProductosMasVendidos).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 367);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(890, 214);
            dataGridView1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(46, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(134, 62);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "HISTORIAL\r\nDE VENTAS\r\n";
            // 
            // chartIngresos
            // 
            chartArea1.Name = "ChartArea1";
            chartIngresos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartIngresos.Legends.Add(legend1);
            chartIngresos.Location = new Point(12, 180);
            chartIngresos.Name = "chartIngresos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartIngresos.Series.Add(series1);
            chartIngresos.Size = new Size(406, 169);
            chartIngresos.TabIndex = 2;
            chartIngresos.Text = "chart1";
            // 
            // chartGanancias
            // 
            chartArea2.Name = "ChartArea1";
            chartGanancias.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartGanancias.Legends.Add(legend2);
            chartGanancias.Location = new Point(546, 33);
            chartGanancias.Name = "chartGanancias";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartGanancias.Series.Add(series2);
            chartGanancias.Size = new Size(313, 164);
            chartGanancias.TabIndex = 3;
            chartGanancias.Text = "chart2";
            // 
            // chartVendedores
            // 
            chartArea3.Name = "ChartArea1";
            chartVendedores.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartVendedores.Legends.Add(legend3);
            chartVendedores.Location = new Point(449, 215);
            chartVendedores.Name = "chartVendedores";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartVendedores.Series.Add(series3);
            chartVendedores.Size = new Size(217, 146);
            chartVendedores.TabIndex = 4;
            chartVendedores.Text = "chart3";
            // 
            // chartProductosMasVendidos
            // 
            chartArea4.Name = "ChartArea1";
            chartProductosMasVendidos.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartProductosMasVendidos.Legends.Add(legend4);
            chartProductosMasVendidos.Location = new Point(672, 215);
            chartProductosMasVendidos.Name = "chartProductosMasVendidos";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartProductosMasVendidos.Series.Add(series4);
            chartProductosMasVendidos.Size = new Size(206, 146);
            chartProductosMasVendidos.TabIndex = 5;
            chartProductosMasVendidos.Text = "chart1";
            // 
            // HistorialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(129, 134, 139);
            ClientSize = new Size(890, 581);
            Controls.Add(chartProductosMasVendidos);
            Controls.Add(chartVendedores);
            Controls.Add(chartGanancias);
            Controls.Add(chartIngresos);
            Controls.Add(lblTitle);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HistorialForm";
            Text = "HistorialForm";
            Load += HistorialForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartIngresos).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartGanancias).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartVendedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartProductosMasVendidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIngresos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGanancias;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVendedores;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductosMasVendidos;
    }
}