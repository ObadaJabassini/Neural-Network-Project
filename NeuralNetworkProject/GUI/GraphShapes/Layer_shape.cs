﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuralNetworkProject.Math;
using NeuralNetworkProject.Properties;
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
        public override ContentAlignment Alignment { get; set; }=ContentAlignment.TopLeft;
        RadDiagramTextShape TextShape = new RadDiagramTextShape();

       // public string textshape = "";
        public Layer_shape(string textshape,Bitmap LayerBitmap):base()
        {
            //this.BackColor = Color.Khaki;
            //this.BackColor = Color.Cornsilk;
            this.BackColor = Color.PaleGoldenrod;
            this.BackColor = Color.DimGray;
            this.ContentShapeElement.BorderColor = System.Drawing.Color.Goldenrod;
            this.ContentShapeElement.BorderColor = System.Drawing.Color.Black;
            this.Shape=new RoundRectShape();
            //this.Text = "\n\n\t";
            this.HeaderPresenter.DrawFill = false;
            //this.BackColor = Color.Bisque;
            this.Size = new Size(150, 150);
            this.Size = new Size(180, 100);
            this.IsConnectorsManipulationEnabled = false;
            this.IsRotationEnabled = false;
            this.IsResizingEnabled = false;
            //this.Shape = new RoundRectShape();
            this.DrawBorder = true;
            
            this.collapseElement.BackgroundImage=new Bitmap(LayerBitmap);
            this.ContentShapeElement.BorderWidth = 4;
            this.collapseElement.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //this.collapseElement.MinSize = new Size(15, 15); this.collapseElement.Text = "-";
            this.collapseElement.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
            //this.collapseElement.DrawBorder = true; this.collapseElement.Click += this.collapseElement_Click;
            this.Children.Add(this.collapseElement);
            TextShape.Text = textshape;
            TextShape.Location=new Telerik.Windows.Diagrams.Core.Point(-5.5,-30);
            TextShape.Alignment=ContentAlignment.TopLeft;
            this.Children.Add(TextShape);
            this.IsEditable = false;
            //this.Label.Alignment=ContentAlignment.TopCenter;
            //this.Label.Location=new Point(80,-40);
            //this.ToggleCollapseButton.ToggleStateChanged += toggleCollapseButton_ToggleStateChanged;
            //this.ToggleCollapseButton.Image = null; //this.ToggleCollapseButton.Font = new Font("segoeUI");
            this.ToggleCollapseButton.Text = "▼"; 
            this.ToggleCollapseButton.ForeColor=Color.DimGray; 
            //this.addnodes();
           // this.UpdateContentBounds(); this.UpdateContainerLayout(); 
        }

        public void addnodes()
        {
            Items.Add(new Feature_shape(this.Location));
            System.Windows.Forms.Application.DoEvents();
        }
    }
}
