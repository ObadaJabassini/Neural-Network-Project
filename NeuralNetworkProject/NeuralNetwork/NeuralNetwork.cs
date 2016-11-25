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

            for (int i = 0; i < layers.Count-1; ++i)
                HiddenWeights.Add(Matrix<double>.Build.Random(layers[i + 1].NeuronsNumber, layers[i].NeuronsNumber + 1));
        }

        public Tuple<IList<Vector<double>>, IList<Vector<double>>> ForwardInput(Vector<double> input)
        {
            IList<Vector<double>> acs = new List<Vector<double>>(),
                                  gs = new List<Vector<double>>();

            input = input.ToColumnMatrix().InsertRow(0, Vector<double>.Build.Dense(new double[] {1})).Column(0);

            acs.Add(input);
            
            Vector<double> temp = input, temp2;
            
            for (int i = 1; i < Layers.Count; i++)
            {
                temp = HiddenWeights[i - 1]*temp; // (n(i)*(n(i-1)+1)) * ((n(i-1)+1)*1) = n(i)*1

                gs.Add(Layers[i].Applier.Gradient(temp));

                temp2 = Layers[i].Applier.Apply(temp);

                if (i < Layers.Count - 1)
                    //add bias
                    temp2 = temp2.ToColumnMatrix().InsertRow(0, Vector<double>.Build.Dense(new double[] {1})).Column(0);

                acs.Add(temp2);

                temp = temp2;
            }

            return new Tuple<IList<Vector<double>>, IList<Vector<double>>>(acs, gs);
        }

        public void UpdateWeightsAt(Matrix<double> deltaW, int index)
        {
            HiddenWeights[index] += deltaW;
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
        public int NeuronNumber { get; set; }
    }
}
