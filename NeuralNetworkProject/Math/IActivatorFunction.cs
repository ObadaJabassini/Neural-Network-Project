using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworkProject.Math
{
    public interface IActivatorFunction
    {
        Matrix<double> Apply(Matrix<double> value);
        Matrix<double> Gradient(Matrix<double> value);
    }
}
