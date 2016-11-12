using static NeuralNetworkProject.LoadData;

namespace NeuralNetworkProject
{
    partial class LoadData
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Train = new Telerik.WinControls.UI.RadButton();
            this.BP = new Telerik.WinControls.UI.RadPanel();
            this.Epochs = new Telerik.WinControls.UI.RadLabel();
            this.epochs_num = new System.Windows.Forms.NumericUpDown();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.Hdn_num = new System.Windows.Forms.NumericUpDown();
            this.Algorithem = new Telerik.WinControls.UI.RadDropDownList();
            this.LoadData_btn = new Telerik.WinControls.UI.RadButton();
            Input_plt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            LoadData_dlg = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Train)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BP)).BeginInit();
            this.BP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Epochs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epochs_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hdn_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Algorithem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadData_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(Input_plt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Train
            // 
            this.Train.Location = new System.Drawing.Point(57, 311);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(106, 24);
            this.Train.TabIndex = 7;
            this.Train.Text = "Train";
            // 
            // BP
            // 
            this.BP.Controls.Add(this.Epochs);
            this.BP.Controls.Add(this.epochs_num);
            this.BP.Controls.Add(this.radLabel1);
            this.BP.Controls.Add(this.Hdn_num);
            this.BP.Location = new System.Drawing.Point(9, 140);
            this.BP.Name = "BP";
            this.BP.Size = new System.Drawing.Size(200, 165);
            this.BP.TabIndex = 4;
            this.BP.Text = "BackProbagation";
            this.BP.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Epochs
            // 
            this.Epochs.Location = new System.Drawing.Point(3, 60);
            this.Epochs.Name = "Epochs";
            this.Epochs.Size = new System.Drawing.Size(42, 18);
            this.Epochs.TabIndex = 3;
            this.Epochs.Text = "Epochs";
            // 
            // epochs_num
            // 
            this.epochs_num.Location = new System.Drawing.Point(93, 58);
            this.epochs_num.Name = "epochs_num";
            this.epochs_num.Size = new System.Drawing.Size(104, 20);
            this.epochs_num.TabIndex = 2;
            this.epochs_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(3, 27);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(77, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Hidden Layers";
            // 
            // Hdn_num
            // 
            this.Hdn_num.Location = new System.Drawing.Point(93, 25);
            this.Hdn_num.Name = "Hdn_num";
            this.Hdn_num.Size = new System.Drawing.Size(104, 20);
            this.Hdn_num.TabIndex = 0;
            this.Hdn_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Algorithem
            // 
            radListDataItem1.Text = "BackProbagation";
            radListDataItem2.Text = "BackProbagation with Momentum";
            radListDataItem3.Text = "Simple Perceptron";
            this.Algorithem.Items.Add(radListDataItem1);
            this.Algorithem.Items.Add(radListDataItem2);
            this.Algorithem.Items.Add(radListDataItem3);
            this.Algorithem.Location = new System.Drawing.Point(12, 100);
            this.Algorithem.Name = "Algorithem";
            this.Algorithem.Size = new System.Drawing.Size(197, 20);
            this.Algorithem.TabIndex = 3;
            // 
            // LoadData_btn
            // 
            this.LoadData_btn.Location = new System.Drawing.Point(53, 40);
            this.LoadData_btn.Name = "LoadData_btn";
            this.LoadData_btn.Size = new System.Drawing.Size(110, 24);
            this.LoadData_btn.TabIndex = 5;
            this.LoadData_btn.Text = "Load Data";
            this.LoadData_btn.Click += new System.EventHandler(this.LoadData_btn_Click);
            // 
            // Input_plt
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "Input";
            Input_plt.ChartAreas.Add(chartArea1);
            Input_plt.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend1.Name = "Legend1";
            Input_plt.Legends.Add(legend1);
            Input_plt.Location = new System.Drawing.Point(245, 22);
            Input_plt.Name = "Input_plt";
            Input_plt.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "Input";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Data";
            series1.YValuesPerPoint = 2;
            Input_plt.Series.Add(series1);
            Input_plt.Size = new System.Drawing.Size(519, 373);
            Input_plt.TabIndex = 0;
            Input_plt.Text = "chart1";
            // 
            // LoadData_dlg
            // 
            LoadData_dlg.DefaultExt = "txt";
            LoadData_dlg.DereferenceLinks = false;
            LoadData_dlg.FileName = "openFileDialog1";
            LoadData_dlg.Filter = "Excel files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            LoadData_dlg.FileOk += new System.ComponentModel.CancelEventHandler(this.LoadData_dlg_FileOk);
            // 
            // LoadData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 442);
            this.Controls.Add(Input_plt);
            this.Controls.Add(this.Train);
            this.Controls.Add(this.BP);
            this.Controls.Add(this.Algorithem);
            this.Controls.Add(this.LoadData_btn);
            this.Name = "LoadData";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "LoadData";
            this.Load += new System.EventHandler(this.LoadData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Train)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BP)).EndInit();
            this.BP.ResumeLayout(false);
            this.BP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Epochs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epochs_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hdn_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Algorithem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadData_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(Input_plt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton Train;
        private Telerik.WinControls.UI.RadPanel BP;
        private Telerik.WinControls.UI.RadLabel Epochs;
        private System.Windows.Forms.NumericUpDown epochs_num;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.NumericUpDown Hdn_num;
        private Telerik.WinControls.UI.RadDropDownList Algorithem;
        private Telerik.WinControls.UI.RadButton LoadData_btn;
        public static System.Windows.Forms.OpenFileDialog LoadData_dlg;
        public static System.Windows.Forms.DataVisualization.Charting.Chart Input_plt;
    }
}
