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
        public override void Train(NeuralNetwork.NeuralNetwork neuralNetwork, Matrix<double> trainingSet, Matrix<double> crossValidationSet, Matrix<double> trainingSetOutput, Matrix<double> crossValidationSetOutput, HyperParameters hyperParameters = null)
        {
            double maxError = 0.01, error = 5;
            int maxEpochs = 1000, epochs = 0;

            if (hyperParameters != null)
            {
                if(maxEpochs <= 0)
                    throw new ArgumentException("Max Epochs cannot be negative");
                if(maxError > 2 || maxError < 0)
                    throw new ArgumentException("Max error cannot be negative or very large");
                maxError = hyperParameters.MaxError;
                maxEpochs = hyperParameters.MaxEpochs;
            }

            TrainingErrorMessage message = new TrainingErrorMessage() { NeuralNetwork = neuralNetwork, TrainingSet = trainingSet, CrossValidationSet = crossValidationSet, TrainingSetOutput = trainingSetOutput, CrossValidationSetOutput = crossValidationSetOutput};
            var layers = neuralNetwork.Layers;
            var weights = neuralNetwork.HiddenWeights;

            //for momentum
            IList<Matrix<double>> prevDeltaW = new List<Matrix<double>>();
            for (int i = 0; i < weights.Count; ++i)
                prevDeltaW.Add(Matrix<double>.Build.Dense(layers[i + 1].NeuronsNumber, layers[i].NeuronsNumber + 1));
            //end

            while(error > maxError && epochs++ <= maxEpochs)
            {
                for (int i = 0; i < trainingSet.RowCount; i++)
                {
                    Vector<double> input  = trainingSet.Row(i),
                                   output = trainingSetOutput.Column(i);
                    var temp = neuralNetwork.ForwardInput(input);
                    IList<Vector<double>> acs = temp.Item1, gs = temp.Item2;

                    var D = (output - acs[acs.Count - 1]).PointwiseMultiply(gs[gs.Count - 1]).ToColumnMatrix(); // n(output) * 1
                    var deltaW = layers[layers.Count - 1].LearningRate * D * acs[acs.Count - 2].ToRowMatrix(); // (n(output) * 1) * ((n(output-1)+1) * 1)' = n(output) * (n(output-1)+1)
                    //for momentum
                    deltaW += computeAdditionalTerms(deltaW, prevDeltaW[weights.Count - 1]);
                    prevDeltaW[weights.Count - 1] = deltaW;
                    //end
                    neuralNetwork.UpdateWeightsAt(deltaW, weights.Count - 1);

                    for (int j = layers.Count - 2; j > 0; j--)
                    {
                        D = (weights[j].Transpose() * D).RemoveRow(0).PointwiseMultiply(gs[j - 1].ToColumnMatrix()); // (n(j+1) * (n(j)+1))' * (n(j+1) * 1) = (n(j)+1) * 1, then => (n(j) * 1) .* (n(j) * 1)
                        deltaW = layers[j].LearningRate * D * acs[j - 1].ToRowMatrix(); // (n(j) * 1) * ((n(j-1)+1) * 1)' = n(j) * (n(j-1)+1)
                        //for momentum
                        deltaW += computeAdditionalTerms(deltaW, prevDeltaW[j - 1]);
                        prevDeltaW[j - 1] = deltaW;
                        //end                        
                        neuralNetwork.UpdateWeightsAt(deltaW, j - 1);
                    }
                }
                base.Notify(message);
                error = message.Error; 
            }
            base.OnComplete();
        }

        protected virtual Matrix<double> computeAdditionalTerms(Matrix<double> currentDeltaW, Matrix<double> prevDeltaW)
        {
            //return a matrix of zeros for standard BP without momentum
            return Matrix<double>.Build.Dense(currentDeltaW.RowCount, currentDeltaW.ColumnCount);
        }

    }
}


