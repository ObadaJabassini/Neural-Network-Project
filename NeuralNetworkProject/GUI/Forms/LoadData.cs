using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GeometryClassLibrary;
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
        private Controller.trainerParams Params;
        private HyperParameters _hyperParameters = null;
        private BackpropagationAlgorithm _bp = new BackpropagationAlgorithm();
        private BackPropagationWithMomentum _bpm = new BackPropagationWithMomentum();

        public LoadData()
        {
            InitializeComponent();
            Controller.InitiateGraph(radDiagram1);
        }


        private void LoadData_Load(object sender, EventArgs e)
        {
            Trainer.TrainingAlgorithm = _bp;
            _hyperParameters.MaxEpochs = 1000;
            _hyperParameters.MaxError = 0.01;
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
            Params=Controller.BuildNet(this.flowLayoutPanel1, LoadData_dlg, r, radDiagram1);

        }

        private void radDiagram1_Click(object sender, EventArgs e)
        {

        }

        private void Algorithem_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (Algorithm.SelectedIndex)
            {
                //case 2:
                //    Trainer.TrainingAlgorithm = _sp;
                //    momentum.Enabled = false;
                //    break;
                case 1:
                    Trainer.TrainingAlgorithm = _bpm;
                        momentum.Enabled = true;
                        _hyperParameters.Momentum = (double)momentum.Value;
                    break;
                case 0:
                    Trainer.TrainingAlgorithm = _bp;
                        momentum.Enabled = false;
                    break;
            }
           
            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _hyperParameters.MaxEpochs = (int)EpochsNum.Value;
            r.MaxEpochs.Text = ((int)EpochsNum.Value).ToString();
            r.Epochs_prgbr.Maximum = (int)EpochsNum.Value;
        }

        private void Train_Click(object sender, EventArgs e)
        {
            r.Show();
            r.EllapsedTimer.Start();
            Trainer.Subscribe(r);
            Trainer.Train(Params.nn, Params.Tuple.Item1, Params.Tuple.Item2, _hyperParameters);
            r.EllapsedTimer.Stop();
        }

        private void momentum_ValueChanged(object sender, EventArgs e)
        {
            _hyperParameters.Momentum = (double) momentum.Value;
        }

        private void layers2_Load(object sender, EventArgs e)
        {

        }

        private void radTrackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
