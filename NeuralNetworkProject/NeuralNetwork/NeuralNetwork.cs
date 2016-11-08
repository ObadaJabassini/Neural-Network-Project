using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.NeuralNetwork
{
    public class NeuralNetwork
    {
        public ICollection<Layer> Layers { get; }
    }

    public class Layer
    {
        public int NeuronNumber { get; set; }
    }
}
