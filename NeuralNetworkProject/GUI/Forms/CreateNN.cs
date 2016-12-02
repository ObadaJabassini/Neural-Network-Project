using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GeometryClassLibrary;
using MaterialSkin;
using MaterialSkin.Controls;
using NeuralNetworkProject.DataAdapter;
using NeuralNetworkProject.GUI.CostumControls;
using NeuralNetworkProject.NeuralNetwork;
using NeuralNetworkProject.Properties;
using NeuralNetworkProject.Training;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;
using Point = System.Drawing.Point;
using RadDiagram = Telerik.WinControls.UI.RadDiagram;

namespace NeuralNetworkProject.GUI.Forms
{
    public partial class CreateNN : RadForm
    {

        private readonly Result r = new Result();
        private Trainer Trainer = new Trainer();
        private Controller.trainerParams Params;
        private HyperParameters _hyperParameters = new HyperParameters();
        private BackpropagationAlgorithm _bp = new BackpropagationAlgorithm();
        private BackPropagationWithMomentumAlgorithm _bpm = new BackPropagationWithMomentumAlgorithm();
        private LevenbergAlgorithm _l=new LevenbergAlgorithm();
        Regex reg = new Regex(@"[0-9]+((.)?[0-9])");

        public CreateNN()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
           // materialSkinManager.AddFormToManage(this);
           // materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.BlueGrey900, Primary.LightBlue200, Accent.LightBlue200, TextShade.WHITE);

            lollipopFile.Dialog = LoadData_dlg;
            lollipopFile.Font = new System.Drawing.Font("Tahoma", 8f);
           
            Controller.InitiateGraph(this.radDiagram1);
        }

        private void CreateNN_Load(object sender, EventArgs e)
        {
            Trainer.TrainingAlgorithm = _bp;
            _hyperParameters.MaxEpochs = 1000;
            _hyperParameters.MaxError = 0.01;
            _hyperParameters.BlendingFactor = 0.01;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void l_ctrl_mat1_Load(object sender, EventArgs e)
        {

        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider3_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void lollipopFileInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lollipopFileInput1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Trainer.TrainingAlgorithm = _bp;

        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {

        }

        private void radToggleButton1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void radPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radButton1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void radButton1_Click_1(object sender, EventArgs e)
        {
            radDiagram1.Controls.Clear();
            Controller.Initiate();
            Params = Controller.BuildNet(this.flowLayoutPanel1, LoadData_dlg, r, radDiagram1);
        }

        private void radButton1_MouseEnter(object sender, EventArgs e)
        {
            radButton1.Image = Resources.settings_r;
        }

        private void radButton1_MouseLeave(object sender, EventArgs e)
        {
            radButton1.Image = Resources.settings;
        }

        private void radPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new L_ctrl_mat());
        }

        private void radTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            radDiagram1.Zoom=radTrackBar1.Value;
        }

        private void radDiagram1_Click(object sender, EventArgs e)
        {

        }

        private void radHScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            radDiagram1.HorizontalScroll.Value = radHScrollBar1.Value;
            radDiagram1.Refresh();

            System.Windows.Forms.Application.DoEvents();
        }

        private void radHScrollBar1_ScrollParameterChanged(object sender, EventArgs e)
        {
            

        }

        private void radDiagram1_ZoomChanged(object sender, Telerik.WinControls.UI.Diagrams.DiagramZoomEventArgs e)
        {
            radTrackBar1.Value = (float) radDiagram1.Zoom;
        }

        private void radRadioButton1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {

        }

        private void radPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radToggleSwitch1_ValueChanged(object sender, EventArgs e)
        {
            if (Momentum_tgl.Value)
            {
                momentum.Enabled = true;
                Trainer.TrainingAlgorithm = _bpm;
            }
            else
            {
                momentum.Enabled = false;
                Trainer.TrainingAlgorithm = _bp;
            }
        }

        private void EpochsNum_ValueChanged(object sender, EventArgs e)
        {
            _hyperParameters.MaxEpochs = (int)EpochsNum.Value;
            r.MaxEpochs.Text = ((int)EpochsNum.Value).ToString();
            r.Epochs_prgbr.Maximum = (int)EpochsNum.Value;
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            r.Show();
            r.LC_GC.Series[0].Points.Clear();
            r.LC_GC.Series[1].Points.Clear();
            r.EllapsedTimer.Start();
            Trainer.Subscribe(r);
            Trainer.Divider.Divider=new StaticDivider(.7);
            Trainer.Train(Params.nn, Params.Tuple.Item1, Params.Tuple.Item2, _hyperParameters);
            r.EllapsedTimer.Stop();

        }

        private void momentum_ValueChanged(object sender, EventArgs e)
        {
            _hyperParameters.Momentum = (double)momentum.Value;
        }

        private void decimalCounter1_Load(object sender, EventArgs e)
        {

        }

        private void intCounter2_Load(object sender, EventArgs e)
        {

        }

        private void intCounter2_Validated(object sender, EventArgs e)
        {
            _hyperParameters.BlendingFactor = intCounter2.Value;
        }

        private void materialRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Trainer.TrainingAlgorithm = _l;
        }

        

    }
}
