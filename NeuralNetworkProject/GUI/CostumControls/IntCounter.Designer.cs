namespace NeuralNetworkProject.GUI.CostumControls
{
    partial class IntCounter
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
            this.increase = new Telerik.WinControls.UI.RadButton();
            this.decrease = new Telerik.WinControls.UI.RadButton();
            this.value = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.increase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // increase
            // 
            this.increase.Dock = System.Windows.Forms.DockStyle.Top;
            this.increase.Location = new System.Drawing.Point(0, 0);
            this.increase.Name = "increase";
            this.increase.Size = new System.Drawing.Size(23, 12);
            this.increase.TabIndex = 24;
            this.increase.Text = "▲";
            this.increase.ThemeName = "VisualStudio2012Dark";
            this.increase.Click += new System.EventHandler(this.increase_Click);
            // 
            // decrease
            // 
            this.decrease.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.decrease.Location = new System.Drawing.Point(0, 18);
            this.decrease.Name = "decrease";
            this.decrease.Size = new System.Drawing.Size(23, 10);
            this.decrease.TabIndex = 25;
            this.decrease.Text = "▼";
            this.decrease.ThemeName = "VisualStudio2012Dark";
            this.decrease.Click += new System.EventHandler(this.decrease_Click);
            // 
            // value
            // 
            this.value.Depth = 0;
            this.value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.value.Hint = "";
            this.value.Location = new System.Drawing.Point(0, 0);
            this.value.MouseState = MaterialSkin.MouseState.HOVER;
            this.value.Name = "value";
            this.value.PasswordChar = '\0';
            this.value.SelectedText = "";
            this.value.SelectionLength = 0;
            this.value.SelectionStart = 0;
            this.value.Size = new System.Drawing.Size(95, 23);
            this.value.TabIndex = 26;
            this.value.Text = "0";
            this.value.UseSystemPasswordChar = false;
            this.value.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            this.value.Validated += new System.EventHandler(this.materialSingleLineTextField1_Validated);
            this.value.Validating += new System.ComponentModel.CancelEventHandler(this.value_Validating);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.increase);
            this.radPanel1.Controls.Add(this.decrease);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel1.Location = new System.Drawing.Point(72, 0);
            this.radPanel1.MaximumSize = new System.Drawing.Size(23, 28);
            this.radPanel1.MinimumSize = new System.Drawing.Size(23, 28);
            this.radPanel1.Name = "radPanel1";
            // 
            // 
            // 
            this.radPanel1.RootElement.MaxSize = new System.Drawing.Size(23, 28);
            this.radPanel1.RootElement.MinSize = new System.Drawing.Size(23, 28);
            this.radPanel1.Size = new System.Drawing.Size(23, 28);
            this.radPanel1.TabIndex = 27;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Opacity = 0D;
            // 
            // IntCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.value);
            this.Name = "IntCounter";
            this.Size = new System.Drawing.Size(95, 28);
            ((System.ComponentModel.ISupportInitialize)(this.increase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected Telerik.WinControls.UI.RadButton increase;
        protected Telerik.WinControls.UI.RadButton decrease;
        protected MaterialSkin.Controls.MaterialSingleLineTextField value;
        private Telerik.WinControls.UI.RadPanel radPanel1;

    }
}
