using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworkProject.NeuralNetwork;

namespace NeuralNetworkProject.Training
{
    public class BackpropagationAlgorithm : ITrainingAlgorithm
    {
        public Tuple<IList<Matrix<double>>, IList<double>, IList<double>> Train(NeuralNetwork.NeuralNetwork neuralNetwork, Matrix<double> trainingSet, Matrix<double> crossValidationSet, Matrix<double> trainingSetOutput, Matrix<double> crossValidationSetOutput, HyperParameters hyperParameters = null)
        {
            double[] learningRates;
            double maxError = 0.01, error = 5;
            int maxEpochs = 1000, epochs = 0;
            if (hyperParameters == null)
            {
                learningRates = new double[neuralNetwork.HiddenWeights.Count];
                for (int i = 0; i < learningRates.Length; i++)
                {
                    learningRates[i] = 0.01;
                }
            }
            else
            {
                if (hyperParameters.LearningRates.Length != neuralNetwork.HiddenWeights.Count)
                    throw new ArgumentException("Learning rate number should equal hidden weights number");
                if(maxEpochs <= 0)
                    throw new ArgumentException("Max Epochs cannot be negative");
                if(maxError > 2 || maxError < 0)
                    throw new ArgumentException("Max error cannot be negative or very large");
                learningRates = hyperParameters.LearningRates;
                maxError = hyperParameters.maxError;
                maxEpochs = hyperParameters.maxEpochs;
            }
            while(error > maxError || epochs++ <= maxEpochs)
            {
                for (int i = 0; i < trainingSet.RowCount; i++)
                {
                    Vector<double> input  = trainingSet.Row(i),
                                   output = trainingSetOutput.Row(i);
                    IList<Vector<double>> activations = neuralNetwork.ForwardInput(input);
                    error = computeError(activations[activations.Count - 1], output);

                }
            }
            return null;
        }

        protected virtual Matrix<double> computeNextWeights()
        {
            return null;
        }

        protected virtual double computeError(Vector<double> outputs, Vector<double> realOutputs)
        {
            return (outputs - realOutputs).Select(element => element * element).Sum();
        }
    }
}


