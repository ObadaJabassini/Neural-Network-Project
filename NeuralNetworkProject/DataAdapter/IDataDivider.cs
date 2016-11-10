using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.DataAdapter
{
    public interface IDataDivider
    {
        Tuple<Matrix<double>, Matrix<double>, Matrix<double>, Matrix<double>> Divide(Matrix<double> inputs, Matrix<double> outputs, params object[] parameters);
    }
}
