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
            this.radTrackBar1 = new Telerik.WinControls.UI.RadTrackBar();
            this.radDiagram1 = new Telerik.WinControls.UI.RadDiagram();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDiagram1)).BeginInit();
            this.radDiagram1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTrackBar1
            // 
            this.radTrackBar1.Location = new System.Drawing.Point(3, 123);
            this.radTrackBar1.Name = "radTrackBar1";
            this.radTrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // 
            // 
            this.radTrackBar1.RootElement.StretchHorizontally = false;
            this.radTrackBar1.RootElement.StretchVertically = true;
            this.radTrackBar1.ShowItemToolTips = false;
            this.radTrackBar1.Size = new System.Drawing.Size(37, 156);
            this.radTrackBar1.TabIndex = 1;
            this.radTrackBar1.Text = "radTrackBar1";
            this.radTrackBar1.TrackBarMode = Telerik.WinControls.UI.TrackBarRangeMode.Range;
            // 
            // radDiagram1
            // 
            this.radDiagram1.Controls.Add(this.radTrackBar1);
            this.radDiagram1.Location = new System.Drawing.Point(232, -3);
            this.radDiagram1.Name = "radDiagram1";
            this.radDiagram1.Size = new System.Drawing.Size(437, 400);
            this.radDiagram1.TabIndex = 2;
            this.radDiagram1.Text = "radDiagram1";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(58, 96);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "radButton1";
            // 
            // Graph_Training
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 409);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radDiagram1);
            this.Name = "Graph_Training";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Graph_Training";
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDiagram1)).EndInit();
            this.radDiagram1.ResumeLayout(false);
            this.radDiagram1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTrackBar radTrackBar1;
        private Telerik.WinControls.UI.RadDiagram radDiagram1;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
