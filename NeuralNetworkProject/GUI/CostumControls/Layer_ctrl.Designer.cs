using NeuralNetworkProject.Math;

namespace NeuralNetworkProject
{
    partial class Layer_ctrl
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            this.NN_drpdn = new System.Windows.Forms.NumericUpDown();
            this.AF_drpdn = new Telerik.WinControls.UI.RadDropDownList();
            this.Lr_drpdn = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NN_drpdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AF_drpdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lr_drpdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NN_drpdn
            // 
            this.NN_drpdn.Location = new System.Drawing.Point(87, 2);
            this.NN_drpdn.Name = "NN_drpdn";
            this.NN_drpdn.Size = new System.Drawing.Size(46, 20);
            this.NN_drpdn.TabIndex = 3;
            this.NN_drpdn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AF_drpdn
            // 
            this.AF_drpdn.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Text = "SIGMOID";
            this.AF_drpdn.Items.Add(radListDataItem1);
            this.AF_drpdn.Location = new System.Drawing.Point(3, 1);
            this.AF_drpdn.Name = "AF_drpdn";
            this.AF_drpdn.Size = new System.Drawing.Size(78, 20);
            this.AF_drpdn.TabIndex = 0;
            this.AF_drpdn.Text = "AF";
            this.AF_drpdn.ThemeName = "Office2010Black";
            // 
            // Lr_drpdn
            // 
            this.Lr_drpdn.DecimalPlaces = 3;
            this.Lr_drpdn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Lr_drpdn.Location = new System.Drawing.Point(139, 2);
            this.Lr_drpdn.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Lr_drpdn.Name = "Lr_drpdn";
            this.Lr_drpdn.Size = new System.Drawing.Size(52, 20);
            this.Lr_drpdn.TabIndex = 12;
            this.Lr_drpdn.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NeuralNetworkProject.Properties.Resources.mouse_x;
            this.pictureBox1.Location = new System.Drawing.Point(197, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Layer_ctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lr_drpdn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AF_drpdn);
            this.Controls.Add(this.NN_drpdn);
            this.Name = "Layer_ctrl";
            this.Size = new System.Drawing.Size(220, 24);
            ((System.ComponentModel.ISupportInitialize)(this.NN_drpdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AF_drpdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lr_drpdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown NN_drpdn;
        public Telerik.WinControls.UI.RadDropDownList AF_drpdn;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.NumericUpDown Lr_drpdn;
    }
}
