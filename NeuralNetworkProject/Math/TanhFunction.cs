using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.Math
{
    internal class TanhFunction : IActivatorFunction
    {
        internal TanhFunction() { }
        public Vector<double> Apply(Vector<double> value) => value.Map(element => 2 * SpecialFunctions.Logistic(2 * element) - 1);
        public Vector<double> Gradient(Vector<double> value)
        {

            var applyResult = Apply(value);
            return  1 - applyResult.PointwiseMultiply(applyResult);
        }

        public Vector<double> Hessian(Vector<double> value)
        {
            var applyResult = Apply(value);
            return -2 * applyResult.PointwiseMultiply(1 - applyResult.PointwiseMultiply(applyResult));
        }

        public override string ToString()
        {
            return "Tanh";
        }
    }
}
