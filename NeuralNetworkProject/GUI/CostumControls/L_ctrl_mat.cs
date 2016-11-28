using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetworkProject.Math;

namespace NeuralNetworkProject.GUI.CostumControls
{
    public partial class L_ctrl_mat : UserControl
    {
        public L_ctrl_mat()
        {
            InitializeComponent();
            AF_drpdn.Items.Add(ActivatorFunctions.FunctionName.SIGMOID.ToString());
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AF_drpdn_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
