using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.GUI
{
    public class ResultMesssage
    {
        internal double LCError { set; get; }
        internal double GCError { set; get; }
        internal int Epochs { set; get; }
        public ResultMesssage(double lcerror, double gcerror, int epochs=1000)
        {
            this.LCError = lcerror;
            this.GCError = gcerror;
            this.Epochs = epochs;
        }
    }
}
