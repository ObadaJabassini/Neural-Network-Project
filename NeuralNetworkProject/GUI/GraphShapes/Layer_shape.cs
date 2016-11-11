using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ANN_test
{
    class Layer_shape: RadDiagramContainerShape
    {
        public Layer_shape()
        {
            this.Shape=new RoundRectShape();
            this.BackColor=Color.Bisque;
        }
    }
}
