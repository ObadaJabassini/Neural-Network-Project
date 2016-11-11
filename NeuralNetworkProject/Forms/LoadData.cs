using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace NeuralNetworkProject
{
    public partial class LoadData : Telerik.WinControls.UI.RadForm
    {
        public LoadData()
        {
            InitializeComponent();
        }

        private void LoadData_Load(object sender, EventArgs e)
        {

        }

        private void LoadData_btn_Click(object sender, EventArgs e)
        {
            LoadData_dlg.ShowDialog();
        }
    }
}
