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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LC_GC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.Performance_prgbr = new Telerik.WinControls.UI.RadProgressBar();
            this.MaxEpochs = new System.Windows.Forms.Label();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.Epochs_prgbr = new Telerik.WinControls.UI.RadProgressBar();
            this.customShape1 = new Telerik.WinControls.OldShapeEditor.CustomShape();
            ((System.ComponentModel.ISupportInitialize)(this.LC_GC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Performance_prgbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epochs_prgbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // LC_GC
            // 
            this.LC_GC.BackColor = System.Drawing.Color.LightSalmon;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.Name = "Input";
            this.LC_GC.ChartAreas.Add(chartArea3);
            this.LC_GC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LC_GC.Dock = System.Windows.Forms.DockStyle.Top;
            legend3.Name = "Legend1";
            this.LC_GC.Legends.Add(legend3);
            this.LC_GC.Location = new System.Drawing.Point(0, 0);
            this.LC_GC.Name = "LC_GC";
            this.LC_GC.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.LC_GC.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))))};
            series5.ChartArea = "Input";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "LC";
            series5.YValuesPerPoint = 2;
            series6.ChartArea = "Input";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "GC";
            this.LC_GC.Series.Add(series5);
            this.LC_GC.Series.Add(series6);
            this.LC_GC.Size = new System.Drawing.Size(600, 391);
            this.LC_GC.TabIndex = 1;
            this.LC_GC.Text = "chart1";
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.Transparent;
            this.radPanel1.Controls.Add(this.label1);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.Performance_prgbr);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(455, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "0";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(61, 53);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(81, 18);
            this.radLabel2.TabIndex = 8;
            this.radLabel2.Text = "Performance :";
            // 
            // Performance_prgbr
            // 
            this.Performance_prgbr.AutoScroll = true;
            this.Performance_prgbr.BackColor = System.Drawing.Color.White;
            this.Performance_prgbr.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Performance_prgbr.EnableCodedUITests = true;
            this.Performance_prgbr.EnableKeyMap = true;
            this.Performance_prgbr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Performance_prgbr.Location = new System.Drawing.Point(143, 53);
            this.Performance_prgbr.Maximum = 10000;
            this.Performance_prgbr.Name = "Performance_prgbr";
            this.Performance_prgbr.Size = new System.Drawing.Size(306, 24);
            this.Performance_prgbr.StepWidth = 10;
            this.Performance_prgbr.TabIndex = 7;
            this.Performance_prgbr.Text = "0 ";
            this.Performance_prgbr.ThemeName = "ControlDefault";
            this.Performance_prgbr.Value1 = 10000;
            ((Telerik.WinControls.UI.RadProgressBarElement)(this.Performance_prgbr.GetChildAt(0))).Value1 = 10000;
            ((Telerik.WinControls.UI.RadProgressBarElement)(this.Performance_prgbr.GetChildAt(0))).Maximum = 10000;
            ((Telerik.WinControls.UI.RadProgressBarElement)(this.Performance_prgbr.GetChildAt(0))).Step = 10;
            ((Telerik.WinControls.UI.RadProgressBarElement)(this.Performance_prgbr.GetChildAt(0))).Text = "0 ";
            ((Telerik.WinControls.UI.RadProgressBarElement)(this.Performance_prgbr.GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.UI.RadProgressBarElement)(this.Performance_prgbr.GetChildAt(0))).HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            ((Telerik.WinControls.UI.RadProgressBarElement)(this.Performance_prgbr.GetChildAt(0))).BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.Performance_prgbr.GetChildAt(0).GetChildAt(1))).BackColor2 = System.Drawing.Color.LightSalmon;
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.Performance_prgbr.GetChildAt(0).GetChildAt(1))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(199)))), ((int)(((byte)(96)))));
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.Performance_prgbr.GetChildAt(0).GetChildAt(1))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(199)))), ((int)(((byte)(96)))));
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.Performance_prgbr.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.LightSalmon;
            // 
            // MaxEpochs
            // 
            this.MaxEpochs.AutoSize = true;
            this.MaxEpochs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.MaxEpochs.Location = new System.Drawing.Point(455, 28);
            this.MaxEpochs.Name = "MaxEpochs";
            this.MaxEpochs.Size = new System.Drawing.Size(30, 13);
            this.MaxEpochs.TabIndex = 6;
            this.MaxEpochs.Text = "Max";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(61, 23);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(50, 18);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Epochs :";
            // 
            // Epochs_prgbr
            // 
            this.Epochs_prgbr.AutoScroll = true;
            this.Epochs_prgbr.BackColor = System.Drawing.Color.White;
            this.Epochs_prgbr.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Epochs_prgbr.EnableCodedUITests = true;
            this.Epochs_prgbr.EnableKeyMap = true;
            this.Epochs_prgbr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Epochs_prgbr.Location = new System.Drawing.Point(143, 23);
            this.Epochs_prgbr.Maximum = 1001;
            this.Epochs_prgbr.Name = "Epochs_prgbr";
            this.Epochs_prgbr.Size = new System.Drawing.Size(306, 24);
            this.Epochs_prgbr.StepWidth = 10;
            this.Epochs_prgbr.TabIndex = 3;
            this.Epochs_prgbr.Text = "0 ";
            this.Epochs_prgbr.ThemeName = "ControlDefault";
            this.Epochs_prgbr.Value1 = 100;
            ((Telerik.WinControls.UI.RadProgressBarElement)(this.Epochs_prgbr.GetChildAt(0))).Value1 = 100;
            ((Telerik.WinControls.UI.RadProgressBarElement)(this.Epochs_prgbr.GetChildAt(0))).Maximum = 1001;
            ((Telerik.WinControls.UI.RadProgressBarElement)(this.Epochs_prgbr.GetChildAt(0))).Step = 10;
            ((Telerik.WinControls.UI.RadProgressBarElement)(this.Epochs_prgbr.GetChildAt(0))).Text = "0 ";
            ((Telerik.WinControls.UI.RadProgressBarElement)(this.Epochs_prgbr.GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.UI.RadProgressBarElement)(this.Epochs_prgbr.GetChildAt(0))).HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            ((Telerik.WinControls.UI.RadProgressBarElement)(this.Epochs_prgbr.GetChildAt(0))).BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.Epochs_prgbr.GetChildAt(0).GetChildAt(1))).BackColor2 = System.Drawing.Color.LightSalmon;
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.Epochs_prgbr.GetChildAt(0).GetChildAt(1))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(199)))), ((int)(((byte)(96)))));
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.Epochs_prgbr.GetChildAt(0).GetChildAt(1))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(199)))), ((int)(((byte)(96)))));
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.Epochs_prgbr.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.LightSalmon;
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
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Performance_prgbr)).EndInit();
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
        public System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        public Telerik.WinControls.UI.RadProgressBar Performance_prgbr;
    }
}
