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
        public Layer_shape(string text):base()
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

            this.addnodes();
        }

        private void addnodes()
        {
            Items.Add(new Feature_shape());

            System.Windows.Forms.Application.DoEvents();
        }
    }
}
