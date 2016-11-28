using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Diagrams;
using Color = System.Drawing.Color;

namespace NeuralNetworkProject.GUI
{
    class Feature_shape:RadDiagramShape
    {
        public Feature_shape(Point location,string text="")
        {
            this.Shape=new EllipseShape();
            //this.BackColor=Color.CornflowerBlue;
            this.Size=new Size(40,40);
            this.Text = text;
            this.Location = location;

        }

        public Feature_shape()
        {
            this.Shape = new EllipseShape();
            //this.BackColor = Color.CornflowerBlue;
            this.Size = new Size(40, 40);

        }
    }
}
