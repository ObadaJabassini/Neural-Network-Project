namespace NeuralNetworkProject.GUI.CostumControls
{
    partial class L_ctrl_mat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lr_drpdn = new System.Windows.Forms.NumericUpDown();
            this.AF_drpdn = new Telerik.WinControls.UI.RadDropDownList();
            this.NN_drpdn = new System.Windows.Forms.NumericUpDown();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Lr_drpdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AF_drpdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NN_drpdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lr_drpdn
            // 
            this.Lr_drpdn.DecimalPlaces = 3;
            this.Lr_drpdn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Lr_drpdn.Location = new System.Drawing.Point(142, 3);
            this.Lr_drpdn.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Lr_drpdn.Name = "Lr_drpdn";
            this.Lr_drpdn.Size = new System.Drawing.Size(66, 20);
            this.Lr_drpdn.TabIndex = 16;
            this.Lr_drpdn.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // AF_drpdn
            // 
            this.AF_drpdn.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.AF_drpdn.Location = new System.Drawing.Point(6, 3);
            this.AF_drpdn.Name = "AF_drpdn";
            this.AF_drpdn.Size = new System.Drawing.Size(78, 24);
            this.AF_drpdn.TabIndex = 13;
            this.AF_drpdn.Text = "AF";
            this.AF_drpdn.ThemeName = "VisualStudio2012Dark";
            this.AF_drpdn.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.AF_drpdn_SelectedIndexChanged);
            // 
            // NN_drpdn
            // 
            this.NN_drpdn.Location = new System.Drawing.Point(90, 3);
            this.NN_drpdn.Name = "NN_drpdn";
            this.NN_drpdn.Size = new System.Drawing.Size(46, 20);
            this.NN_drpdn.TabIndex = 14;
            this.NN_drpdn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NeuralNetworkProject.Properties.Resources.recycle;
            this.pictureBox1.Location = new System.Drawing.Point(214, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // L_ctrl_mat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Lr_drpdn);
            this.Controls.Add(this.AF_drpdn);
            this.Controls.Add(this.NN_drpdn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "L_ctrl_mat";
            this.Size = new System.Drawing.Size(242, 48);
            ((System.ComponentModel.ISupportInitialize)(this.Lr_drpdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AF_drpdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NN_drpdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown Lr_drpdn;
        public Telerik.WinControls.UI.RadDropDownList AF_drpdn;
        public System.Windows.Forms.NumericUpDown NN_drpdn;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
