namespace NeuralNetworkProject.GUI.CostumControls
{
    partial class Counter
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
            this.right = new Telerik.WinControls.UI.RadPanel();
            this.left = new Telerik.WinControls.UI.RadPanel();
            this.Increase = new MaterialSkin.Controls.MaterialFlatButton();
            this.Decrease = new MaterialSkin.Controls.MaterialFlatButton();
            this.object_2dad1df9_0118_459c_af89_179e212e3ff0 = new Telerik.WinControls.RootRadElement();
            this._value = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            this.right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            this.left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._value)).BeginInit();
            this.SuspendLayout();
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.LightSeaGreen;
            this.right.Controls.Add(this.Increase);
            this.right.Dock = System.Windows.Forms.DockStyle.Right;
            this.right.Location = new System.Drawing.Point(63, 0);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(16, 21);
            this.right.TabIndex = 1;
            this.right.Text = "radPanel2";
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.LightSeaGreen;
            this.left.Controls.Add(this.Decrease);
            this.left.Dock = System.Windows.Forms.DockStyle.Left;
            this.left.Location = new System.Drawing.Point(0, 0);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(14, 21);
            this.left.TabIndex = 2;
            this.left.Text = "radPanel3";
            // 
            // Increase
            // 
            this.Increase.AutoSize = true;
            this.Increase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Increase.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Increase.BackgroundImage = global::NeuralNetworkProject.Properties.Resources._39567a_add_database_128;
            this.Increase.Depth = 0;
            this.Increase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Increase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Increase.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Increase.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Increase.Image = global::NeuralNetworkProject.Properties.Resources._39567a_add_database_128;
            this.Increase.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Increase.Location = new System.Drawing.Point(0, 0);
            this.Increase.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Increase.MouseState = MaterialSkin.MouseState.HOVER;
            this.Increase.Name = "Increase";
            this.Increase.Primary = false;
            this.Increase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Increase.Size = new System.Drawing.Size(16, 21);
            this.Increase.TabIndex = 2;
            this.Increase.Text = ">";
            this.Increase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Increase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Increase.UseVisualStyleBackColor = false;
            // 
            // Decrease
            // 
            this.Decrease.AutoSize = true;
            this.Decrease.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Decrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(71)))));
            this.Decrease.BackgroundImage = global::NeuralNetworkProject.Properties.Resources._39567a_add_database_128;
            this.Decrease.Depth = 0;
            this.Decrease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Decrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decrease.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrease.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Decrease.Image = global::NeuralNetworkProject.Properties.Resources._39567a_add_database_128;
            this.Decrease.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Decrease.Location = new System.Drawing.Point(0, 0);
            this.Decrease.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Decrease.MouseState = MaterialSkin.MouseState.HOVER;
            this.Decrease.Name = "Decrease";
            this.Decrease.Primary = false;
            this.Decrease.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Decrease.Size = new System.Drawing.Size(14, 21);
            this.Decrease.TabIndex = 3;
            this.Decrease.Text = "<";
            this.Decrease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Decrease.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Decrease.UseVisualStyleBackColor = false;
            // 
            // object_2dad1df9_0118_459c_af89_179e212e3ff0
            // 
            this.object_2dad1df9_0118_459c_af89_179e212e3ff0.Name = "object_2dad1df9_0118_459c_af89_179e212e3ff0";
            this.object_2dad1df9_0118_459c_af89_179e212e3ff0.StretchHorizontally = true;
            this.object_2dad1df9_0118_459c_af89_179e212e3ff0.StretchVertically = true;
            // 
            // _value
            // 
            this._value.BackColor = System.Drawing.SystemColors.WindowText;
            this._value.Dock = System.Windows.Forms.DockStyle.Fill;
            this._value.ForeColor = System.Drawing.Color.Silver;
            this._value.Location = new System.Drawing.Point(14, 0);
            this._value.Name = "_value";
            this._value.Size = new System.Drawing.Size(49, 20);
            this._value.TabIndex = 3;
            this._value.Text = "0";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this._value.GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.Silver;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this._value.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this._value.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.Silver;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this._value.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            // 
            // Counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._value);
            this.Controls.Add(this.left);
            this.Controls.Add(this.right);
            this.Name = "Counter";
            this.Size = new System.Drawing.Size(79, 21);
            this.Load += new System.EventHandler(this.Counter_Load);
            this.Validated += new System.EventHandler(this.DecimalCounter_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            this.right.ResumeLayout(false);
            this.right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            this.left.ResumeLayout(false);
            this.left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel right;
        private Telerik.WinControls.UI.RadPanel left;
        private MaterialSkin.Controls.MaterialFlatButton Increase;
        private MaterialSkin.Controls.MaterialFlatButton Decrease;
        private Telerik.WinControls.RootRadElement object_2dad1df9_0118_459c_af89_179e212e3ff0;
        private Telerik.WinControls.UI.RadTextBox _value;

    }
}
