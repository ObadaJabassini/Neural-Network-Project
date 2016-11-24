using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetworkProject.Properties;
using Telerik.WinControls.Tests;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Diagrams;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;

namespace NeuralNetworkProject.GUI.GraphShapes
{
    class AF_shape:RadDiagramShape
    {
        public AF_shape(Point location, string text)
        {
            this.Shape = new DonutShape();
            this.BackColor = Color.CornflowerBlue;
            this.Size = new Size(40, 40);
            this.Text = text;
            this.Location = location;
        }
        public AF_shape()
        {
            this.Shape = new DonutShape();
            this.BackColor = Color.CornflowerBlue;
            this.Size = new Size(40, 40);
        }
    }
}
