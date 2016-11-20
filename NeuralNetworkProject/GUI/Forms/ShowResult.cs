using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NeuralNetworkProject.GUI;
using NeuralNetworkProject.Training;

namespace NeuralNetworkProject
{
    public partial class  Result :IObserver<ResultMesssage>
    {
         public void OnNext(ResultMesssage value)
         {
             //this.LC_GC.Series[0].Points.Add( value.Epochs,value.LCError);
             //this.LC_GC.Series[1].Points.Add(value.Epochs, value.GCError);
            this.LC_GC.Series[0].Points.Add(value.LCError,value.Epochs);
            this.LC_GC.Series[1].Points.Add(value.GCError, value.Epochs);
            this.LC_GC.Refresh();
            Epochs_prgbr.Text = Convert.ToString(value.Epochs);
            Epochs_prgbr.Value1 = value.Epochs;
            System.Windows.Forms.Application.DoEvents();
             Epochs_prgbr.Refresh();
             //EpochsBar.Text = Convert.ToString(value.Epochs);
             //EpochsBar.Value = value.Epochs;
             //EpochsBar.Refresh();
             //EpochsValue.Text = Convert.ToString(value.Epochs);
         }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            this.LC_GC.Refresh();
        }
    }
}
