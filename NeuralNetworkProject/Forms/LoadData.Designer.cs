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
            this.Network_creat = new Telerik.WinControls.UI.RadButton();
            this.BP = new Telerik.WinControls.UI.RadPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoadData_btn = new Telerik.WinControls.UI.RadButton();
            this.Algorithem = new Telerik.WinControls.UI.RadDropDownList();
            this.EpochsNum = new System.Windows.Forms.NumericUpDown();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.layers2 = new NeuralNetworkProject.Layer_ctrl();
            this.layers1 = new NeuralNetworkProject.Layer_ctrl();
            this.AddNewLayer = new Telerik.WinControls.UI.RadButton();
            this.Train = new Telerik.WinControls.UI.RadButton();
            this.Epochs = new Telerik.WinControls.UI.RadLabel();
            this.epochs_num = new System.Windows.Forms.NumericUpDown();
            this.LoadData_dlg = new System.Windows.Forms.OpenFileDialog();
            this.radDiagram1 = new Telerik.WinControls.UI.RadDiagram();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            ((System.ComponentModel.ISupportInitialize)(this.Network_creat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BP)).BeginInit();
            this.BP.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadData_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Algorithem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Train)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epochs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epochs_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Network_creat
            // 
            this.Network_creat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Network_creat.Location = new System.Drawing.Point(0, 249);
            this.Network_creat.Name = "Network_creat";
            this.Network_creat.Size = new System.Drawing.Size(249, 24);
            this.Network_creat.TabIndex = 7;
            this.Network_creat.Text = "Create Network";
            this.Network_creat.ThemeName = "Office2010Black";
            this.Network_creat.Click += new System.EventHandler(this.Network_creat_Click);
            // 
            // BP
            // 
            this.BP.BackColor = System.Drawing.Color.DarkSalmon;
            this.BP.Controls.Add(this.panel2);
            this.BP.Controls.Add(this.panel1);
            this.BP.Controls.Add(this.Train);
            this.BP.Dock = System.Windows.Forms.DockStyle.Left;
            this.BP.Location = new System.Drawing.Point(0, 0);
            this.BP.Name = "BP";
            this.BP.Size = new System.Drawing.Size(277, 442);
            this.BP.TabIndex = 4;
            this.BP.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.BP.ThemeName = "Office2010Black";
            this.BP.Paint += new System.Windows.Forms.PaintEventHandler(this.BP_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LoadData_btn);
            this.panel2.Controls.Add(this.Algorithem);
            this.panel2.Controls.Add(this.EpochsNum);
            this.panel2.Controls.Add(this.radLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 123);
            this.panel2.TabIndex = 11;
            // 
            // LoadData_btn
            // 
            this.LoadData_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoadData_btn.Location = new System.Drawing.Point(0, 0);
            this.LoadData_btn.Name = "LoadData_btn";
            this.LoadData_btn.Size = new System.Drawing.Size(277, 37);
            this.LoadData_btn.TabIndex = 5;
            this.LoadData_btn.Text = "Load Data";
            this.LoadData_btn.ThemeName = "Office2010Black";
            this.LoadData_btn.Click += new System.EventHandler(this.LoadData_btn_Click);
            // 
            // Algorithem
            // 
            radListDataItem1.Text = "BackProbagation";
            radListDataItem2.Text = "BackProbagation with Momentum";
            radListDataItem3.Text = "Simple Perceptron";
            this.Algorithem.Items.Add(radListDataItem1);
            this.Algorithem.Items.Add(radListDataItem2);
            this.Algorithem.Items.Add(radListDataItem3);
            this.Algorithem.Location = new System.Drawing.Point(37, 92);
            this.Algorithem.Name = "Algorithem";
            this.Algorithem.Size = new System.Drawing.Size(197, 20);
            this.Algorithem.TabIndex = 3;
            this.Algorithem.Text = "Choose Algorithm";
            this.Algorithem.ThemeName = "Office2010Black";
            this.Algorithem.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.Algorithem_SelectedIndexChanged);
            // 
            // EpochsNum
            // 
            this.EpochsNum.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.EpochsNum.Location = new System.Drawing.Point(118, 55);
            this.EpochsNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.EpochsNum.Name = "EpochsNum";
            this.EpochsNum.Size = new System.Drawing.Size(61, 20);
            this.EpochsNum.TabIndex = 1;
            this.EpochsNum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.EpochsNum.Visible = false;
            this.EpochsNum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(71, 55);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(43, 18);
            this.radLabel1.TabIndex = 10;
            this.radLabel1.Text = "Epochs";
            this.radLabel1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.AddNewLayer);
            this.panel1.Controls.Add(this.Network_creat);
            this.panel1.Location = new System.Drawing.Point(13, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 273);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.flowLayoutPanel1.Controls.Add(this.layers2);
            this.flowLayoutPanel1.Controls.Add(this.layers1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(249, 228);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // layers2
            // 
            this.layers2.Location = new System.Drawing.Point(3, 3);
            this.layers2.Name = "layers2";
            this.layers2.Size = new System.Drawing.Size(222, 24);
            this.layers2.TabIndex = 1;
            // 
            // layers1
            // 
            this.layers1.Location = new System.Drawing.Point(3, 33);
            this.layers1.Name = "layers1";
            this.layers1.Size = new System.Drawing.Size(222, 24);
            this.layers1.TabIndex = 0;
            // 
            // AddNewLayer
            // 
            this.AddNewLayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddNewLayer.Location = new System.Drawing.Point(0, 225);
            this.AddNewLayer.Name = "AddNewLayer";
            this.AddNewLayer.Size = new System.Drawing.Size(249, 24);
            this.AddNewLayer.TabIndex = 9;
            this.AddNewLayer.Text = "Add New Layer";
            this.AddNewLayer.ThemeName = "Office2010Black";
            this.AddNewLayer.Click += new System.EventHandler(this.AddNewLayer_Click);
            // 
            // Train
            // 
            this.Train.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Train.Location = new System.Drawing.Point(0, 408);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(277, 34);
            this.Train.TabIndex = 2;
            this.Train.Text = "Train";
            this.Train.ThemeName = "Office2010Black";
            this.Train.Click += new System.EventHandler(this.Train_Click);
            // 
            // Epochs
            // 
            this.Epochs.Location = new System.Drawing.Point(583, 419);
            this.Epochs.Name = "Epochs";
            this.Epochs.Size = new System.Drawing.Size(42, 18);
            this.Epochs.TabIndex = 3;
            this.Epochs.Text = "Epochs";
            // 
            // epochs_num
            // 
            this.epochs_num.Location = new System.Drawing.Point(407, 417);
            this.epochs_num.Name = "epochs_num";
            this.epochs_num.Size = new System.Drawing.Size(104, 20);
            this.epochs_num.TabIndex = 2;
            this.epochs_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoadData_dlg
            // 
            this.LoadData_dlg.DefaultExt = "txt";
            this.LoadData_dlg.DereferenceLinks = false;
            this.LoadData_dlg.Filter = "Excel files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.LoadData_dlg.Title = "Open Dataset File";
            this.LoadData_dlg.FileOk += new System.ComponentModel.CancelEventHandler(this.LoadData_dlg_FileOk);
            // 
            // radDiagram1
            // 
            this.radDiagram1.BackColor = System.Drawing.Color.Gray;
            this.radDiagram1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radDiagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDiagram1.Location = new System.Drawing.Point(277, 0);
            this.radDiagram1.Name = "radDiagram1";
            this.radDiagram1.Size = new System.Drawing.Size(484, 442);
            this.radDiagram1.TabIndex = 9;
            this.radDiagram1.Text = "radDiagram1";
            this.radDiagram1.ThemeName = "ControlDefault";
            this.radDiagram1.Zoom = 0.5D;
            this.radDiagram1.Click += new System.EventHandler(this.radDiagram1_Click);
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).ActiveTool = Telerik.Windows.Diagrams.Core.MouseTool.PanTool;
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).ConnectionBridge = Telerik.Windows.Diagrams.Core.BridgeType.None;
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).Zoom = 0.5D;
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderInnerColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderInnerColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderInnerColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderLeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderRightColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            // 
            // LoadData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 442);
            this.Controls.Add(this.radDiagram1);
            this.Controls.Add(this.Epochs);
            this.Controls.Add(this.BP);
            this.Controls.Add(this.epochs_num);
            this.Name = "LoadData";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "LoadData";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.LoadData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Network_creat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BP)).EndInit();
            this.BP.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadData_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Algorithem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddNewLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Train)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epochs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epochs_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton Network_creat;
        private Telerik.WinControls.UI.RadPanel BP;
        private Telerik.WinControls.UI.RadLabel Epochs;
        private System.Windows.Forms.NumericUpDown epochs_num;
        private Telerik.WinControls.UI.RadDropDownList Algorithem;
        private Telerik.WinControls.UI.RadButton LoadData_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Layer_ctrl layers2;
        private Layer_ctrl layers1;
        public System.Windows.Forms.OpenFileDialog LoadData_dlg;
        private Telerik.WinControls.UI.RadButton AddNewLayer;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private Telerik.WinControls.UI.RadDiagram radDiagram1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.NumericUpDown EpochsNum;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton Train;
        private System.Windows.Forms.Panel panel2;
    }
}
