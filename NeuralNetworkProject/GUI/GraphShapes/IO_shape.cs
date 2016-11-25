using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NeuralNetworkProject.GUI.GraphShapes
{
    class IO_shape:RadDiagramShape
    {
        public IO_shape()
        {
            this.BackColor = Color.MediumSpringGreen;

            //this.BackColor = Color.Bisque;
            this.Size = new Size(50, 50);
            this.IsConnectorsManipulationEnabled = false;
            this.IsRotationEnabled = false;
            this.IsResizingEnabled = false;

            this.Shape = new RoundRectShape();
        }
    }

    class Input_shape:IO_shape
    {
        public Input_shape()
        {
            this.Text = "Input";
        }
    }
    class Output_shape:IO_shape
    {
        public Output_shape()
        {
            this.Text = "Output";
        }
    }
}
