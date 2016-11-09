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
        public int MaxEpochs { get; set; }
        public double MaxError { get; set; }
    }
}
