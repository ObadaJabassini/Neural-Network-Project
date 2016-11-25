using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuralNetworkProject.GUI;
using NeuralNetworkProject.Training;

namespace NeuralNetworkProject
{
    public partial class  Result :IObserver<ResultMesssage>
    {
         public void OnNext(ResultMesssage value)
         {;
             this.LC_GC.Series[0].Points.Add( value.Epochs,value.LCError);
             this.LC_GC.Series[1].Points.Add(value.Epochs, value.GCError);
             this.LC_GC.Refresh(); 
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
