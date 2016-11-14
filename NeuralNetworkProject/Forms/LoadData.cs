using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NeuralNetworkProject.GUI;
using NeuralNetworkProject.NeuralNetwork;
using NeuralNetworkProject.Training;
using Telerik.WinControls;
using Telerik.Windows.Diagrams.Core;
using Point = Telerik.Windows.Diagrams.Core.Point;

namespace NeuralNetworkProject
{
    public partial class LoadData : Telerik.WinControls.UI.RadForm
    {
        private readonly Result r=new Result();
        private  Trainer Trainer=new Trainer();
        private Controller.trainerParams Params=new Controller.trainerParams();
        private HyperParameters Hparameters = null;
        public void su()
        {
          
        }
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

        private void LoadData_dlg_FileOk(object sender, CancelEventArgs e)
        {
            if (!(LoadData_dlg.FileName.EndsWith("txt")||(LoadData_dlg.FileName.EndsWith("csv"))))
            {
                //RadMessageBox message=new RadMessageBox()
                //message
                LoadData_dlg.ShowDialog();
            }
        }

        
        private void BP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddNewLayer_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add( new Layer_ctrl());
        }

        private void radVScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void Network_creat_Click(object sender, EventArgs e)
        {
            HyperParameters Hparameters=new HyperParameters();
            Params=Controller.BuildNet(this.flowLayoutPanel1, LoadData_dlg, r, radDiagram1);

        }

        private void radDiagram1_Click(object sender, EventArgs e)
        {

        }

        private void Algorithem_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Hparameters=new HyperParameters();
            Hparameters.MaxEpochs = (int) EpochsNum.Value;
        }

        private void Train_Click(object sender, EventArgs e)
        {
            r.Show();
            Trainer.Subscribe(r);
            Trainer.Train(Params.nn, Params.Tuple.Item1, Params.Tuple.Item2);
        }
        
    }
}
