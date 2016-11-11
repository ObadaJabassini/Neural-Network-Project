namespace NeuralNetworkProject
{
    partial class Result
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.I_O = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LC_GC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.I_O)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LC_GC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // I_O
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "Input";
            this.I_O.ChartAreas.Add(chartArea1);
            this.I_O.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend1.Name = "Legend1";
            this.I_O.Legends.Add(legend1);
            this.I_O.Location = new System.Drawing.Point(21, 31);
            this.I_O.Name = "I_O";
            this.I_O.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "Input";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Data";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "Input";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Output";
            this.I_O.Series.Add(series1);
            this.I_O.Series.Add(series2);
            this.I_O.Size = new System.Drawing.Size(432, 315);
            this.I_O.TabIndex = 2;
            this.I_O.Text = "chart1";
            // 
            // LC_GC
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.Name = "Input";
            this.LC_GC.ChartAreas.Add(chartArea2);
            this.LC_GC.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend2.Name = "Legend1";
            this.LC_GC.Legends.Add(legend2);
            this.LC_GC.Location = new System.Drawing.Point(475, 31);
            this.LC_GC.Name = "LC_GC";
            this.LC_GC.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.LC_GC.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))))};
            series3.ChartArea = "Input";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "LC";
            series3.YValuesPerPoint = 2;
            series4.ChartArea = "Input";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "GC";
            this.LC_GC.Series.Add(series3);
            this.LC_GC.Series.Add(series4);
            this.LC_GC.Size = new System.Drawing.Size(432, 315);
            this.LC_GC.TabIndex = 1;
            this.LC_GC.Text = "chart1";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 477);
            this.Controls.Add(this.LC_GC);
            this.Controls.Add(this.I_O);
            this.Name = "Result";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.I_O)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LC_GC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart I_O;
        private System.Windows.Forms.DataVisualization.Charting.Chart LC_GC;
    }
}
