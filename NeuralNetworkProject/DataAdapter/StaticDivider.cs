using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworkProject.DataAdapter
{
    public class StaticDivider : IDataDivider
    {
        private object[] parameters;

        internal StaticDivider(params object[] param)
        {
            this.parameters = param;
        }
        public Tuple<Matrix<double>, Matrix<double>, Matrix<double>, Matrix<double>> Divide(Matrix<double> inputs, Matrix<double> outputs, params object[] parameters)
        {
            // if (parameters.Length > 0)
            if (this.parameters.Length == 0)
                throw new ArgumentException("U must provide a ratio for training samples");
            double ratio = (this.parameters[0] as Double?).Value;
            var temp = inputs.EnumerateRows();
            var t = outputs.EnumerateRows();
            var t1 = inputs.RowCount * ratio;
            var temp1 = temp.Take(Convert.ToInt32(t1));
            var temp2 = temp.Skip(Convert.ToInt32(t1));
            var temp3 = t.Take(Convert.ToInt32(t1));
            var temp4 = t.Skip(Convert.ToInt32(t1));
            return new Tuple<Matrix<double>, Matrix<double>, Matrix<double>, Matrix<double>>(Matrix<double>.Build.DenseOfRows(temp1), Matrix<double>.Build.DenseOfRows(temp3).Transpose(), Matrix<double>.Build.DenseOfRows(temp2), Matrix<double>.Build.DenseOfRows(temp4).Transpose());
        }
    }
}
