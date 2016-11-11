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
    class Feature_shape:RadDiagramShape
    {
        public Feature_shape()
        {
            this.Shape=new EllipseShape();
            this.BackColor=Color.DodgerBlue;
        }
    }
}
