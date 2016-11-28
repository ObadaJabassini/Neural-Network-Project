using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace NeuralNetworkProject.GUI.CostumControls
{
    public partial class DecimalCounter : UserControl
    {
        [Category("Format")]
        public Double Increment { set; get; }

        [Category("Format")]
        public Double tValue { get; private set; }

        Regex reg = new Regex(@"^\d+(\.\d+)?$");
        RadToolTip _tip = new RadToolTip();
        public DecimalCounter()
        {
            InitializeComponent();

            _tip.IsBalloon = false;
            _tip.ToolTipIcon = ToolTipIcon.Error;
            _tip.AutoPopDelay = 2000;
            _tip.UseAnimation = true;

            _tip.BackColor = Color.LightSeaGreen;
            _tip.ForeColor = Color.FromArgb(34, 44, 71);
        }

        private void DecimalCounter_Validated(object sender, EventArgs e)
        {
            if (!reg.IsMatch(value.Text))
            {
                value.Select();
                _tip.Show("It must be a Decimal non negative", value);
            }
            else
            {
                _tip.Hide();
                tValue = Convert.ToDouble(this.Text);
            }
        }

        private void increase_Click(object sender, EventArgs e)
        {
            this.Text = Convert.ToString(tValue + Increment);
        }

        private void decrease_Click(object sender, EventArgs e)
        {
            this.Text = Convert.ToString(tValue - Increment);
        }
    }
}
