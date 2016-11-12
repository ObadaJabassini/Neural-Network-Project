namespace NeuralNetworkProject
{
    partial class Graph_Training
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
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.Input_plt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).BeginInit();
            this.radCollapsiblePanel1.PanelContainer.SuspendLayout();
            this.radCollapsiblePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Input_plt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(58, 96);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "radButton1";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radCollapsiblePanel1
            // 
            this.radCollapsiblePanel1.ExpandDirection = Telerik.WinControls.UI.RadDirection.Right;
            this.radCollapsiblePanel1.Location = new System.Drawing.Point(124, 18);
            this.radCollapsiblePanel1.Name = "radCollapsiblePanel1";
            // 
            // radCollapsiblePanel1.PanelContainer
            // 
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.Input_plt);
            this.radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(404, 371);
            this.radCollapsiblePanel1.Size = new System.Drawing.Size(432, 373);
            this.radCollapsiblePanel1.TabIndex = 9;
            this.radCollapsiblePanel1.Text = "radCollapsiblePanel1";
            // 
            // Input_plt
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "Input";
            this.Input_plt.ChartAreas.Add(chartArea1);
            this.Input_plt.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend1.Name = "Legend1";
            this.Input_plt.Legends.Add(legend1);
            this.Input_plt.Location = new System.Drawing.Point(0, 3);
            this.Input_plt.Name = "Input_plt";
            this.Input_plt.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "Input";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Data";
            series1.YValuesPerPoint = 2;
            this.Input_plt.Series.Add(series1);
            this.Input_plt.Size = new System.Drawing.Size(402, 365);
            this.Input_plt.TabIndex = 0;
            this.Input_plt.Text = "chart1";
            // 
            // Graph_Training
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 409);
            this.Controls.Add(this.radCollapsiblePanel1);
            this.Controls.Add(this.radButton1);
            this.Name = "Graph_Training";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Graph_Training";
            this.Load += new System.EventHandler(this.Graph_Training_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.radCollapsiblePanel1.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).EndInit();
            this.radCollapsiblePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Input_plt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
        public System.Windows.Forms.DataVisualization.Charting.Chart Input_plt;
    }
}
