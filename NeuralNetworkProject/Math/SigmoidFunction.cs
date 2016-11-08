using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworkProject.Math
{
    internal class SigmoidFunction : IActivatorFunction
    {
        internal SigmoidFunction() { }
        public Matrix<double> Apply(Matrix<double> value)
        {
            return value.Map(element => SpecialFunctions.Logistic(element));
        }

        public Matrix<double> Gradient(Matrix<double> value)
        {
            var applyResult = Apply(value);
            return applyResult * (1 - applyResult);
        }
    }
}
