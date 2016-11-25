using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Diagrams.Core;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace NeuralNetworkProject.GUI
{
    class Layer_shape: RadDiagramContainerShape
    {
        private readonly LightVisualElement collapseElement = new LightVisualElement(); 
        public Layer_shape():base()
        {
            //this.BackColor = Color.Khaki;
            //this.BackColor = Color.Cornsilk;
            this.BackColor = Color.PaleGoldenrod;
            this.HeaderPresenter.DrawFill = false;
            //this.BackColor = Color.Bisque;
            this.Size = new Size(150, 150);
            this.IsConnectorsManipulationEnabled = false;
            this.IsRotationEnabled = false;
            this.IsResizingEnabled = false;
            //this.Shape = new RoundRectShape();
            this.DrawBorder = true;
            this.ContentShapeElement.BorderColor = System.Drawing.Color.Goldenrod;
            this.ContentShapeElement.BorderWidth = 2;
            this.collapseElement.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.collapseElement.MinSize = new Size(15, 15); this.collapseElement.Text = "-";
            this.collapseElement.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
            //this.collapseElement.DrawBorder = true; this.collapseElement.Click += this.collapseElement_Click;
            this.Children.Add(this.collapseElement);
            this.IsEditable = false;
            //this.ToggleCollapseButton.ToggleStateChanged += toggleCollapseButton_ToggleStateChanged;
            //this.ToggleCollapseButton.Image = null; //this.ToggleCollapseButton.Font = new Font("segoeUI");
            //this.ToggleCollapseButton.Text = "▼"; 
            this.addnodes();
            this.UpdateContentBounds(); this.UpdateContainerLayout(); 
        }

        public void addnodes()
        {
            Items.Add(new Feature_shape(this.Location));
            System.Windows.Forms.Application.DoEvents();
        }
    }
}
