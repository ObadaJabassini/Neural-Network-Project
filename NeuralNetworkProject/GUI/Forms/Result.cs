using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NeuralNetworkProject.Training;
using Telerik.WinControls;

namespace NeuralNetworkProject
{
    public partial class Result : Telerik.WinControls.UI.RadForm
    {
        private DateTime _DateTime=new DateTime(1,1,1,0,0,0,0);
        private int _seconds=0;
        public Result()
        {
            InitializeComponent();
           
        }

        private void EllapsedTime_Tick(object sender, EventArgs e)
        {
            _seconds++;
            ElapsedTime.Text = (_DateTime.AddMilliseconds(_seconds*1000)).ToString("HH:mm:ss");
        }
        

    }
}
