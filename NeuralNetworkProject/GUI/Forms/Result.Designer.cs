﻿namespace NeuralNetworkProject
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LC_GC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.MaxEpochs = new System.Windows.Forms.Label();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.Epochs_prgbr = new Telerik.WinControls.UI.RadProgressBar();
            this.customShape1 = new Telerik.WinControls.OldShapeEditor.CustomShape();
            ((System.ComponentModel.ISupportInitialize)(this.LC_GC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epochs_prgbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // LC_GC
            // 
            this.LC_GC.BackColor = System.Drawing.Color.LightSalmon;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.Name = "Input";
            this.LC_GC.ChartAreas.Add(chartArea4);
            this.LC_GC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LC_GC.Dock = System.Windows.Forms.DockStyle.Top;
            legend4.Name = "Legend1";
            this.LC_GC.Legends.Add(legend4);
            this.LC_GC.Location = new System.Drawing.Point(0, 0);
            this.LC_GC.Name = "LC_GC";
            this.LC_GC.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.LC_GC.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))))};
            series7.ChartArea = "Input";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "LC";
            series7.YValuesPerPoint = 2;
            series8.ChartArea = "Input";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "GC";
            this.LC_GC.Series.Add(series7);
            this.LC_GC.Series.Add(series8);
            this.LC_GC.Size = new System.Drawing.Size(600, 391);
            this.LC_GC.TabIndex = 1;
            this.LC_GC.Text = "chart1";
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.White;
            this.radPanel1.Controls.Add(this.MaxEpochs);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Controls.Add(this.Epochs_prgbr);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel1.Location = new System.Drawing.Point(0, 391);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(600, 106);
            this.radPanel1.TabIndex = 2;
            this.radPanel1.ThemeName = "Office2010Black";
            // 
            // MaxEpochs
            // 
            this.MaxEpochs.AutoSize = true;
            this.MaxEpochs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.MaxEpochs.Location = new System.Drawing.Point(443, 33);
            this.MaxEpochs.Name = "MaxEpochs";
            this.MaxEpochs.Size = new System.Drawing.Size(30, 13);
            this.MaxEpochs.TabIndex = 6;
            this.MaxEpochs.Text = "Max";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(66, 28);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(50, 18);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Epochs :";
            // 
            // Epochs_prgbr
            // 
            this.Epochs_prgbr.AutoScroll = true;
            this.Epochs_prgbr.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Epochs_prgbr.EnableCodedUITests = true;
            this.Epochs_prgbr.EnableKeyMap = true;
            this.Epochs_prgbr.Location = new System.Drawing.Point(122, 28);
            this.Epochs_prgbr.Maximum = 1001;
            this.Epochs_prgbr.Name = "Epochs_prgbr";
            this.Epochs_prgbr.Size = new System.Drawing.Size(306, 24);
            this.Epochs_prgbr.StepWidth = 10;
            this.Epochs_prgbr.TabIndex = 3;
            this.Epochs_prgbr.Text = "0 ";
            this.Epochs_prgbr.ThemeName = "ControlDefault";
            // 
            // customShape1
            // 
            this.customShape1.Dimension = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 497);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.LC_GC);
            this.Name = "Result";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Result";
            this.ThemeName = "Office2010Black";
            ((System.ComponentModel.ISupportInitialize)(this.LC_GC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epochs_prgbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart LC_GC;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.OldShapeEditor.CustomShape customShape1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        public System.Windows.Forms.Label MaxEpochs;
        public Telerik.WinControls.UI.RadProgressBar Epochs_prgbr;
    }
}
