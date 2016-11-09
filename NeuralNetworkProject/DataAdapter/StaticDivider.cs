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
        internal StaticDivider() { }
        public Tuple<Matrix<double>, Matrix<double>, Matrix<double>, Matrix<double>> Divide(Matrix<double> inputs, Matrix<double> outputs)
        {
            Console.WriteLine(inputs);
            Console.WriteLine(outputs);
            int firstSize = inputs.RowCount * 6 / 10, secondSize = inputs.RowCount * 3 / 10;
            Matrix<double> trainSet = Matrix<double>.Build.Random(firstSize, inputs.ColumnCount),
                           crossSet = Matrix<double>.Build.Random(secondSize, inputs.ColumnCount),
                           trainOut = Matrix<double>.Build.Random(firstSize, outputs.ColumnCount),
                           crossOut = Matrix<double>.Build.Random(secondSize, outputs.ColumnCount);
            for (int i = 0; i < firstSize; i++)
            {
                trainSet.SetRow(i, inputs.Row(i));
                trainOut.SetRow(i, outputs.Row(i));
            }
            for (int j = 0; j < secondSize; ++j)
            {
                crossSet.SetRow(j, inputs.Row(j + firstSize));
                crossOut.SetRow(j, outputs.Row(j + firstSize));
            }
            return new Tuple<Matrix<double>, Matrix<double>, Matrix<double>, Matrix<double>>(trainSet, trainOut, crossSet, crossOut);
        }
    }
}
