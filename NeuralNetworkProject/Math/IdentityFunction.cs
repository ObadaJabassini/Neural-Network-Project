using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworkProject.Math
{
    internal class IdentityFunction : IActivatorFunction
    {
        internal IdentityFunction() { }
        public Vector<double> Apply(Vector<double> value) => value;
        public Vector<double> Gradient(Vector<double> value)
        {
            return Vector<double>.Build.DenseOfEnumerable(Enumerable.Repeat(1, value.Count).Select(element => Convert.ToDouble(element)));
        }

        public Vector<double> Hessian(Vector<double> value)
        {
            return Vector<double>.Build.DenseOfEnumerable(Enumerable.Repeat(0, value.Count).Select(element => Convert.ToDouble(element)));
        }

        public override string ToString()
        {
            return "Sigmoid";
        }
    }
}
