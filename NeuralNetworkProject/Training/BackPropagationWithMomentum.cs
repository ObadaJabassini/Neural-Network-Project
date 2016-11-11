using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworkProject.Training
{
    class BackPropagationWithMomentum : BackpropagationAlgorithm
    {
        protected override Matrix<double> computeAdditionalTerms(Matrix<double> prevDeltaW, double momentum)
        {
            return momentum*prevDeltaW;
        }
    }
}
