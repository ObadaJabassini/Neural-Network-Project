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
                HiddenWeights[i] = Matrix<double>.Build.Random(layers[i + 1].NeuronsNumber, layers[i].NeuronsNumber + 1);
            }
        }

        public Tuple<IList<Vector<double>>, IList<Vector<double>>> ForwardInput(Vector<double> input)
        {
            IList<Vector<double>> acs = new List<Vector<double>>(),
                                  gs = new List<Vector<double>>();
            Vector<double> temp = input, temp2;
            for (int i = 0; i < HiddenWeights.Count; i++)
            {
                temp = HiddenWeights[i] * temp;
                temp2 = Layers[i + 1].Applier.Apply(temp);
                acs.Add(temp2);
                gs.Add(Layers[i + 1].Applier.Gradient(temp));
                temp = temp2;
            }
            return new Tuple<IList<Vector<double>>, IList<Vector<double>>>(acs, gs);
        }

        public void UpdateWeightsAt(Matrix<double> newWeights, int index)
        {
            HiddenWeights[index] = newWeights;
        }
    }
    
    public class NeuralNetworkBuilder
    {
        private IList<Layer> _layers;

        public NeuralNetworkBuilder()
        {
            _layers = new List<Layer>();
        }

        public NeuralNetworkBuilder Layer(int numOfNeurons, FunctionApplier functionApplier, double learningRate = 0.01)
        {
            _layers.Add(new Layer() { Applier = functionApplier, NeuronsNumber = numOfNeurons, LearningRate = learningRate });
            return this;
        }

        public NeuralNetwork Build() => new NeuralNetwork(_layers);
    }

    public class Layer
    {
        public int NeuronsNumber { get; internal set; }
        public double LearningRate { get; internal set; }
        public FunctionApplier Applier { get; internal set; }
    }
}
