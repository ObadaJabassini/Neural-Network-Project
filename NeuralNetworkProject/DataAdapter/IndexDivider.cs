using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworkProject.DataAdapter
{
    public class IndexDivider : IDataDivider
    {
        internal IndexDivider() { }

        public Tuple<Matrix<double>, Matrix<double>, Matrix<double>, Matrix<double>> Divide(Matrix<double> inputs, Matrix<double> outputs, params object[] paramters)
        {
            IList<int> trainingIndices = (IList<int>) paramters[0],
                       crossIndices    = (IList<int>) paramters[1];
            return new Tuple<Matrix<double>, Matrix<double>, Matrix<double>, Matrix<double>>(Matrix<double>.Build.DenseOfRows(inputs.EnumerateRowsIndexed().Where(t => trainingIndices.Contains(t.Item1)).Select(t => t.Item2)),
                                                                                             Matrix<double>.Build.DenseOfRows(outputs.EnumerateRowsIndexed().Where(t => trainingIndices.Contains(t.Item1)).Select(t => t.Item2)),
                                                                                             Matrix<double>.Build.DenseOfRows(inputs.EnumerateRowsIndexed().Where(t => crossIndices.Contains(t.Item1)).Select(t => t.Item2)),
                                                                                             Matrix<double>.Build.DenseOfRows(outputs.EnumerateRowsIndexed().Where(t => crossIndices.Contains(t.Item1)).Select(t => t.Item2)));
        }
    }
}
