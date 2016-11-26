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
        Vector<double> Apply(Vector<double> value);
        Vector<double> Gradient(Vector<double> value);
        Vector<double> Hessian(Vector<double> value);
    }
}
