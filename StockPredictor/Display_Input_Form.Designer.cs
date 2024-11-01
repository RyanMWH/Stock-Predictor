namespace StockPredictor
{
    partial class Display_Input_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart_stock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataGridView_stock = new System.Windows.Forms.DataGridView();
            this.chart_volume = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart_stock
            // 
            chartArea3.Name = "ChartArea1";
            this.Chart_stock.ChartAreas.Add(chartArea3);
            this.Chart_stock.IsSoftShadows = false;
            legend3.Name = "Legend1";
            this.Chart_stock.Legends.Add(legend3);
            this.Chart_stock.Location = new System.Drawing.Point(131, 26);
            this.Chart_stock.Name = "Chart_stock";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Chart_stock.Series.Add(series3);
            this.Chart_stock.Size = new System.Drawing.Size(1003, 261);
            this.Chart_stock.TabIndex = 0;
            this.Chart_stock.Text = "chart1";
            // 
            // DataGridView_stock
            // 
            this.DataGridView_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_stock.Location = new System.Drawing.Point(81, 636);
            this.DataGridView_stock.Name = "DataGridView_stock";
            this.DataGridView_stock.RowHeadersWidth = 82;
            this.DataGridView_stock.RowTemplate.Height = 33;
            this.DataGridView_stock.Size = new System.Drawing.Size(1453, 444);
            this.DataGridView_stock.TabIndex = 1;
            // 
            // chart_volume
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_volume.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_volume.Legends.Add(legend4);
            this.chart_volume.Location = new System.Drawing.Point(131, 310);
            this.chart_volume.Name = "chart_volume";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart_volume.Series.Add(series4);
            this.chart_volume.Size = new System.Drawing.Size(1003, 300);
            this.chart_volume.TabIndex = 2;
            this.chart_volume.Text = "chart1";
            // 
            // Display_Input_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 1212);
            this.Controls.Add(this.chart_volume);
            this.Controls.Add(this.DataGridView_stock);
            this.Controls.Add(this.Chart_stock);
            this.Name = "Display_Input_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Display_Input_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_volume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart Chart_stock;
        public System.Windows.Forms.DataGridView DataGridView_stock;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_volume;
    }
}