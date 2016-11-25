using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworkProject.DataAdapter
{
    public class IndexedDivider : IDataDivider
    {
        internal IndexedDivider() { }

        public Tuple<Matrix<double>, Matrix<double>, Matrix<double>, Matrix<double>> Divide(Matrix<double> inputs, Matrix<double> outputs, params object[] paramters)
        {
            IEnumerable<int> trainingIndices = paramters[0] as IEnumerable<int>,
                             crossIndices    = paramters[1] as IEnumerable<int>;
            if (trainingIndices == null)
            {
                trainingIndices = Enumerable.Range(0, inputs.RowCount / 2);
            }
            if (crossIndices == null)
            {
                crossIndices = Enumerable.Range(inputs.RowCount / 2 + 1, inputs.RowCount - 1);
            }
            return new Tuple<Matrix<double>, Matrix<double>, Matrix<double>, Matrix<double>>(Matrix<double>.Build.DenseOfRows(inputs.EnumerateRowsIndexed().Where(t => trainingIndices.Contains(t.Item1)).Select(t => t.Item2)),
                                                                                             Matrix<double>.Build.DenseOfRows(outputs.EnumerateRowsIndexed().Where(t => trainingIndices.Contains(t.Item1)).Select(t => t.Item2)).Transpose(),
                                                                                             Matrix<double>.Build.DenseOfRows(inputs.EnumerateRowsIndexed().Where(t => crossIndices.Contains(t.Item1)).Select(t => t.Item2)),
                                                                                             Matrix<double>.Build.DenseOfRows(outputs.EnumerateRowsIndexed().Where(t => crossIndices.Contains(t.Item1)).Select(t => t.Item2)).Transpose());
        }
    }
}
