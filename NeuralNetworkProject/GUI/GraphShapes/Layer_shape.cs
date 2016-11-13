using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NeuralNetworkProject.GUI
{
    class Layer_shape: RadDiagramContainerShape
    {      
        public Layer_shape(string text)
        {
            
            this.Text = text;
            //this.BackColor = Color.Khaki;
            //this.BackColor = Color.Cornsilk;
            this.BackColor = Color.PaleGoldenrod;

            //this.BackColor = Color.Bisque;
            this.Size = new Size(150, 150);
            this.IsConnectorsManipulationEnabled = false;
            this.IsRotationEnabled = false;
            this.IsResizingEnabled = false;
            this.Shape = new RoundRectShape();
        }
    }
}
