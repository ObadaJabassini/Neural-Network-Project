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
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AF_drpdn = new Telerik.WinControls.UI.RadDropDownList();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AF_drpdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(87, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // AF_drpdn
            // 
            this.AF_drpdn.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem2.Text = "SIGMOID";
            this.AF_drpdn.Items.Add(radListDataItem2);
            this.AF_drpdn.Location = new System.Drawing.Point(3, 1);
            this.AF_drpdn.Name = "AF_drpdn";
            this.AF_drpdn.Size = new System.Drawing.Size(78, 20);
            this.AF_drpdn.TabIndex = 0;
            this.AF_drpdn.Text = "AF";
            this.AF_drpdn.ThemeName = "Office2010Black";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NeuralNetworkProject.Properties.Resources.c30000_cut_48;
            this.pictureBox1.Location = new System.Drawing.Point(146, 1);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AF_drpdn);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Layer_ctrl";
            this.Size = new System.Drawing.Size(175, 24);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AF_drpdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public Telerik.WinControls.UI.RadDropDownList AF_drpdn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
