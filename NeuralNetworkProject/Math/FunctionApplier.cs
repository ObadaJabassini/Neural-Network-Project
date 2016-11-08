using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.Math
{
    public class FunctionApplier
    {
        public IActivatorFunction ActivatorFunction { get; set; } = ActivatorFunctions.CreateFunction(ActivatorFunctions.FunctionName.SIGMOID);
        public Vector<double> Apply(Vector<double> value)
        {
            return ActivatorFunction.Apply(value);
        }

        public Vector<double> Gradient(Vector<double> value)
        {
            return ActivatorFunction.Gradient(value);
        }
    }
}
