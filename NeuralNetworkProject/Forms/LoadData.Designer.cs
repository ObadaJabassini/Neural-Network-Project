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
            this.Network_creat = new Telerik.WinControls.UI.RadButton();
            this.BP = new Telerik.WinControls.UI.RadPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Epochs = new Telerik.WinControls.UI.RadLabel();
            this.AddNewLayer = new Telerik.WinControls.UI.RadButton();
            this.epochs_num = new System.Windows.Forms.NumericUpDown();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.Hdn_num = new System.Windows.Forms.NumericUpDown();
            this.Algorithem = new Telerik.WinControls.UI.RadDropDownList();
            this.LoadData_btn = new Telerik.WinControls.UI.RadButton();
            this.Input_plt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LoadData_dlg = new System.Windows.Forms.OpenFileDialog();
            this.layers2 = new NeuralNetworkProject.Layer_ctrl();
            this.layers1 = new NeuralNetworkProject.Layer_ctrl();
            this.radCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            ((System.ComponentModel.ISupportInitialize)(this.Network_creat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BP)).BeginInit();
            this.BP.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Epochs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epochs_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hdn_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Algorithem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadData_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_plt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).BeginInit();
            this.radCollapsiblePanel1.PanelContainer.SuspendLayout();
            this.radCollapsiblePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Network_creat
            // 
            this.Network_creat.Location = new System.Drawing.Point(103, 391);
            this.Network_creat.Name = "Network_creat";
            this.Network_creat.Size = new System.Drawing.Size(106, 24);
            this.Network_creat.TabIndex = 7;
            this.Network_creat.Text = "Creat Network";
            // 
            // BP
            // 
            this.BP.Controls.Add(this.flowLayoutPanel1);
            this.BP.Controls.Add(this.Epochs);
            this.BP.Controls.Add(this.AddNewLayer);
            this.BP.Controls.Add(this.epochs_num);
            this.BP.Controls.Add(this.radLabel1);
            this.BP.Controls.Add(this.Hdn_num);
            this.BP.Location = new System.Drawing.Point(27, 148);
            this.BP.Name = "BP";
            this.BP.Size = new System.Drawing.Size(277, 224);
            this.BP.TabIndex = 4;
            this.BP.Text = "Build the network";
            this.BP.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.BP.Paint += new System.Windows.Forms.PaintEventHandler(this.BP_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.layers2);
            this.flowLayoutPanel1.Controls.Add(this.layers1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(271, 112);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Epochs
            // 
            this.Epochs.Location = new System.Drawing.Point(3, 60);
            this.Epochs.Name = "Epochs";
            this.Epochs.Size = new System.Drawing.Size(42, 18);
            this.Epochs.TabIndex = 3;
            this.Epochs.Text = "Epochs";
            // 
            // AddNewLayer
            // 
            this.AddNewLayer.Location = new System.Drawing.Point(72, 197);
            this.AddNewLayer.Name = "AddNewLayer";
            this.AddNewLayer.Size = new System.Drawing.Size(110, 24);
            this.AddNewLayer.TabIndex = 9;
            this.AddNewLayer.Text = "Add New Layer";
            this.AddNewLayer.Click += new System.EventHandler(this.AddNewLayer_Click);
            // 
            // epochs_num
            // 
            this.epochs_num.Location = new System.Drawing.Point(93, 58);
            this.epochs_num.Name = "epochs_num";
            this.epochs_num.Size = new System.Drawing.Size(104, 22);
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
            this.Hdn_num.Size = new System.Drawing.Size(104, 22);
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
            this.Algorithem.Location = new System.Drawing.Point(74, 104);
            this.Algorithem.Name = "Algorithem";
            this.Algorithem.Size = new System.Drawing.Size(197, 20);
            this.Algorithem.TabIndex = 3;
            // 
            // LoadData_btn
            // 
            this.LoadData_btn.Location = new System.Drawing.Point(111, 43);
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
            // LoadData_dlg
            // 
            this.LoadData_dlg.DefaultExt = "txt";
            this.LoadData_dlg.DereferenceLinks = false;
            this.LoadData_dlg.Filter = "Excel files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.LoadData_dlg.Title = "Open Dataset File";
            this.LoadData_dlg.FileOk += new System.ComponentModel.CancelEventHandler(this.LoadData_dlg_FileOk);
            // 
            // layers2
            // 
            this.layers2.Location = new System.Drawing.Point(3, 3);
            this.layers2.Name = "layers2";
            this.layers2.Size = new System.Drawing.Size(241, 24);
            this.layers2.TabIndex = 1;
            // 
            // layers1
            // 
            this.layers1.Location = new System.Drawing.Point(3, 33);
            this.layers1.Name = "layers1";
            this.layers1.Size = new System.Drawing.Size(241, 24);
            this.layers1.TabIndex = 0;
            // 
            // radCollapsiblePanel1
            // 
            this.radCollapsiblePanel1.ExpandDirection = Telerik.WinControls.UI.RadDirection.Right;
            this.radCollapsiblePanel1.Location = new System.Drawing.Point(310, 27);
            this.radCollapsiblePanel1.Name = "radCollapsiblePanel1";
            // 
            // radCollapsiblePanel1.PanelContainer
            // 
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.Input_plt);
            this.radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(404, 371);
            this.radCollapsiblePanel1.Size = new System.Drawing.Size(432, 373);
            this.radCollapsiblePanel1.TabIndex = 8;
            this.radCollapsiblePanel1.Text = "radCollapsiblePanel1";
            // 
            // LoadData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 442);
            this.Controls.Add(this.radCollapsiblePanel1);
            this.Controls.Add(this.Network_creat);
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
            ((System.ComponentModel.ISupportInitialize)(this.Network_creat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BP)).EndInit();
            this.BP.ResumeLayout(false);
            this.BP.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Epochs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epochs_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hdn_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Algorithem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadData_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_plt)).EndInit();
            this.radCollapsiblePanel1.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).EndInit();
            this.radCollapsiblePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton Network_creat;
        private Telerik.WinControls.UI.RadPanel BP;
        private Telerik.WinControls.UI.RadLabel Epochs;
        private System.Windows.Forms.NumericUpDown epochs_num;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.NumericUpDown Hdn_num;
        private Telerik.WinControls.UI.RadDropDownList Algorithem;
        private Telerik.WinControls.UI.RadButton LoadData_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Layer_ctrl layers2;
        private Layer_ctrl layers1;
        public System.Windows.Forms.OpenFileDialog LoadData_dlg;
        public System.Windows.Forms.DataVisualization.Charting.Chart Input_plt;
        private Telerik.WinControls.UI.RadButton AddNewLayer;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
    }
}
