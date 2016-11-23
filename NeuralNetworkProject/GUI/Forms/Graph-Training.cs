using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NeuralNetworkProject.GUI;
using Telerik.WinControls;
using Telerik.Windows.Diagrams.Core;
using Point = Telerik.Windows.Diagrams.Core.Point;

namespace NeuralNetworkProject
{
    public partial class Graph_Training : Telerik.WinControls.UI.RadForm
    {
        private NeuralNetwork.NeuralNetwork _network;
        public Graph_Training(NeuralNetwork.NeuralNetwork network)
        {
            _network = network;
            InitializeComponent();
        }

        private void Graph_Training_Load(object sender, EventArgs e)
        {
            
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void radTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            //radDiagram1.Zoom = radTrackBar1.Value;
        }

        private void radDiagram1_Click(object sender, EventArgs e)
        {

        }
    }
}
