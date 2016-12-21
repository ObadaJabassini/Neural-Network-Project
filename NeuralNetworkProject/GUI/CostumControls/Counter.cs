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
            get
            {
                if (checkRegex()) return Convert.ToDouble(_value.Text);
                return 0;
            }
        }

        [Category("Format")]
        public bool IsDecimal {
             set
            {
                regex = value ? new Regex(@"^\d+(\.\d+)?$") : new Regex(@"^\d+$");
                _isDecimal = value;
            }
            get { return _isDecimal; }
        }

        private bool _isDecimal { set; get; } = false;

        private Regex regex = new Regex(@"^\d+(\.\d+)?$");
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
            this.Validated += _value_TextChanged;
            this._value.LostFocus+=ValueOnLostFocus;
        }

        private void ValueOnLostFocus(object sender, EventArgs eventArgs)
        {
            checkRegex();
        }

        private void Counter_Validated(object sender, EventArgs e)
        {
            //checkRegex();
        }

        private void Increase_Click(object sender, EventArgs e)
        {
            if (checkRegex())
                this._value.Text = Convert.ToString(Value + Increment);
        }

        private void Decrease_Click(object sender, EventArgs e)
        {
            if(checkRegex())
                this._value.Text = Convert.ToString(Value - Increment);
        }

        private void Counter_Load(object sender, EventArgs e)
        {

        }

        private void _value_TextChanged(object sender, EventArgs e)
        {
            checkRegex();
        }

        private bool checkRegex()
        {
            if (regex.IsMatch(_value.Text))
            {
                _tip.Hide();
                Value = Convert.ToDouble(_value.Text);
                return true;
            }
            else
            {
                _tip.Show(
                    IsDecimal
                        ? "It must be a Decimal non negative number !!"
                        : "It must be an Integer non negative number !!", _value);

                _value.Focus();
                return false;
            }
        }

    }
}
