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

namespace NeuralNetworkProject
{
    public partial class Layer_ctrl : UserControl
    {
        public Layer_ctrl()
        {
            InitializeComponent(); 
            
        }

        public Layer_ctrl(string num)
        {
            this.radLabel1.Text += " "+num+" :";
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
