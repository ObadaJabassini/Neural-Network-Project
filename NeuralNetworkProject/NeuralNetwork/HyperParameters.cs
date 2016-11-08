using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.NeuralNetwork
{
    public class HyperParameters
    {
        public double[] LearningRates { get; set; }
        public int maxEpochs { get; set; }
        public double maxError { get; set; }
    }
}
