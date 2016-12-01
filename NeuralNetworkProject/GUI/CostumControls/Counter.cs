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
    public partial class Counter : UserControl
    {
        [Category("Format")]
        public Double Increment { set; get; }

        [Category("Format")]
        public Double Value {
            set
            {
                _value.Text = value.ToString();
            }
            get { return Convert.ToDouble(_value.Text); }
        }

        [Category("Format")] 
        public bool IsDecimal { set; get; }

        Regex regex ;
        RadToolTip _tip = new RadToolTip();
        public Counter()
        {
            InitializeComponent();

            _tip.IsBalloon = false;
            _tip.ToolTipIcon = ToolTipIcon.Error;
            _tip.AutoPopDelay = 2000;
            _tip.UseAnimation = true;

            _tip.BackColor = Color.LightSeaGreen;
            _tip.ForeColor = Color.FromArgb(34, 44, 71);

            regex = IsDecimal ? new Regex(@"^\d+(\.\d+)?$") : new Regex(@"^\d+$");
        }

        private void DecimalCounter_Validated(object sender, EventArgs e)
        {
            if (regex.IsMatch(_value.Text))
            {
                _tip.Hide();
                Value = Convert.ToDouble(this.Text);
            }

            else
            {
                _value.Select();
                if (IsDecimal)
                    _tip.Show("It must be a Decimal non negative number !!", _value);
                else
                    _tip.Show("It must be an Integer non negative number !!", _value);
            }

        }

        private void increase_Click(object sender, EventArgs e)
        {
            this._value.Text = Convert.ToString(Value + Increment);
            this.Refresh();
        }

        private void decrease_Click(object sender, EventArgs e)
        {
            this._value.Text = Convert.ToString(Value - Increment);
        }
    }
}
