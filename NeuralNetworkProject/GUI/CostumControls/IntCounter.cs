using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetworkProject.Properties;
using Telerik.WinControls;

namespace NeuralNetworkProject.GUI.CostumControls
{
    public partial class IntCounter : UserControl
    {
        [Category("Format")]
        public Double Increment { set; get; }

        [Category("Format")]
        public Double Value { get; private set; }

        Regex reg = new Regex(@"^\d+$");
        RadToolTip _tip = new RadToolTip();
        
        public IntCounter()
        {
            InitializeComponent();

            _tip.IsBalloon = false;
            _tip.ToolTipIcon=ToolTipIcon.Error;
            _tip.AutoPopDelay = 2000;
            _tip.UseAnimation = true;

            _tip.BackColor = Color.LightSeaGreen;
            _tip.ForeColor = Color.FromArgb(34, 44, 71);
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Validated(object sender, EventArgs e)
        {

           
        }

        private void value_Validating(object sender, CancelEventArgs e)
        {
            if (!reg.IsMatch(value.Text))
            {
                value.Select();
                _tip.Show("It must be an Integer non negative", value);
            }
            else
            {
                _tip.Hide();
                Value = Convert.ToDouble(this.Text);
            }
        }

        private void decrease_Click(object sender, EventArgs e)
        {
            this.Text = Convert.ToString(Value - Increment);
        }

        private void increase_Click(object sender, EventArgs e)
        {
            this.Text = Convert.ToString(Value + Increment);
        }
    }
}
