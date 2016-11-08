using MathNet.Numerics.LinearAlgebra;
using NeuralNetworkProject.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.NeuralNetwork
{
    public class NeuralNetwork
    {
        public IList<Layer> Layers { get; private set; }
        public IList<Matrix<double>> HiddenWeights { get; private set; }

        internal NeuralNetwork(IList<Layer> layers)
        {
            this.Layers = layers;
            HiddenWeights = new List<Matrix<double>>(layers.Count - 1);
            for (int i = 0; i < HiddenWeights.Count; ++i)
            {
                HiddenWeights[i] = Matrix<double>.Build.Random(layers[i + 1].NeuronNumber, layers[i].NeuronNumber + 1);
            }
        }

        public IList<Matrix<double>> ForwardInput(Matrix<double> input)
        {
            return null;
        }
    }
    
    public class NeuralNetworkBuilder
    {
        private IList<Layer> _layers;

        public NeuralNetworkBuilder()
        {
            _layers = new List<Layer>();
        }

        public NeuralNetworkBuilder Layer(int numOfNeurons, FunctionApplier functionApplier)
        {
            _layers.Add(new Layer() { Applier = functionApplier, NeuronNumber = numOfNeurons});
            return this;
        }

        public NeuralNetwork Build()
        {
            return new NeuralNetwork(_layers);
        }
    }

    public class Layer
    {
        public int NeuronNumber { get; internal set; }
        public FunctionApplier Applier { get; internal set; }
    }
}
