using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworkProject.NeuralNetwork;

namespace NeuralNetworkProject.Training
{
    public class BackpropagationAlgorithm : TrainingAlgorithm
    {
        public override Tuple<IList<IList<Matrix<double>>>, IList<double>, IList<double>> Train(NeuralNetwork.NeuralNetwork neuralNetwork, Matrix<double> trainingSet, Matrix<double> crossValidationSet, Matrix<double> trainingSetOutput, Matrix<double> crossValidationSetOutput, HyperParameters hyperParameters = null)
        {
            double[] learningRates;
            double maxError = 0.01, error = 5;
            int maxEpochs = 1000, epochs = 0;
            IList<double> trainErrors      = new List<double>(),
                          validationErrors = new List<double>();
            var weights = new List<IList<Matrix<double>>>();
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
                maxError = hyperParameters.MaxError;
                maxEpochs = hyperParameters.MaxEpochs;
            }
            TrainingErrorMessage message = new TrainingErrorMessage() { NeuralNetwork = neuralNetwork, TrainingSet = trainingSet, CrossValidationSet = crossValidationSet, TrainingSetOutput = trainingSetOutput, CrossValidationSetOutput = crossValidationSetOutput};
            while(error > maxError && epochs++ <= maxEpochs)
            {
                for (int i = 0; i < trainingSet.RowCount; i++)
                {
                    Vector<double> input  = trainingSet.Row(i),
                                   output = trainingSetOutput.Row(i);
                    var activations = neuralNetwork.ForwardInput(input);
                }
                base.Notify(message);
                error = message.Error; 
            }
            base.OnComplete();
            return new Tuple<IList<IList<Matrix<double>>>, IList<double>, IList<double>>(weights, trainErrors, validationErrors);
        }

        protected virtual Matrix<double> computeAdditionalTerms()
        {
            return null;
        }

    }
}


