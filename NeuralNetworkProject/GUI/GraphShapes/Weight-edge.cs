using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Diagrams.Core;

namespace NeuralNetworkProject.GUI
{
    class Weight_edge : RadDiagramConnection
    {
        public Weight_edge(Telerik.WinControls.UI.RadDiagram diagram,int i  )
        {
            TargetCapType = CapType.Arrow2;
            //BackColor = Color.Gold;
            //diagram.AddConnection((IShape) diagram.Shapes[i], (IShape) diagram.Shapes[i - 1]);
            //diagram.Connections[diagram.Connections.Count].TargetCapType=CapType.Arrow2 ;
            //diagram.Connections[diagram.Connections.Count].BackColor=BackColor ;
           
            //this.connn
            //this.Shape=new 
        }
    }
}
