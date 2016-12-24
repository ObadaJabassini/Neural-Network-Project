using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworkProject.NeuralNetwork;
using Telerik.Windows.Diagrams.Core;

namespace NeuralNetworkProject.Training
{
    internal class LevenbergAlgorithm : TrainingAlgorithm
    {
        internal LevenbergAlgorithm()
        {
        }

        public override void Train(NeuralNetwork.NeuralNetwork neuralNetwork, Matrix<double> trainingSet,
            Matrix<double> crossValidationSet, Matrix<double> trainingSetOutput, Matrix<double> crossValidationSetOutput,
            HyperParameters hyperParameters = null)
        {
            double maxError = 0.01, error = 5;
            int maxEpochs = 1000, epochs = 0;
            if (hyperParameters != null)
            {
                if (maxEpochs <= 0)
                    throw new ArgumentException("Max Epochs cannot be negative");
                if (maxError > 2 || maxError < 0)
                    throw new ArgumentException("Max error cannot be negative or very large");
                maxError = hyperParameters.MaxError;
                maxEpochs = hyperParameters.MaxEpochs;
            }

            double mue = 0.001, mue_adj = 10, max_mue = 1e10;
            
            TrainingErrorMessage message = new TrainingErrorMessage()
            {
                NeuralNetwork = neuralNetwork,
                TrainingSet = trainingSet,
                CrossValidationSet = crossValidationSet,
                TrainingSetOutput = trainingSetOutput,
                CrossValidationSetOutput = crossValidationSetOutput
            };
            base.Notify(message);

            double currentError = message.Error;
            while (currentError >= maxError && epochs++ < maxEpochs)
            {
                message.Epochs = epochs;

                var temp = HissienAndGragient(neuralNetwork, trainingSet, trainingSetOutput);
                var hessien = temp.Item1;
                var gradient = temp.Item2;
                Matrix<double> blendingMatrix = Matrix<double>.Build.DenseDiagonal(hessien.RowCount, hessien.ColumnCount);
                var prevW = neuralNetwork.HiddenWeights.ToList();
                //Console.WriteLine("prev :");
                //prevW.ForEach(Console.WriteLine);
                double nextError = 100000;
                while (true)
                {
                    var term = hessien + mue*blendingMatrix;
                    var det = term.Determinant();

                    if (System.Math.Abs(det) > 0)
                    {
                        var deltaW = term*gradient;
                        neuralNetwork.UpdateWeightsFromVector(deltaW);
                        //Console.WriteLine("updated :");
                        //neuralNetwork.HiddenWeights.ForEach(Console.WriteLine);
                        base.Notify(message);
                        nextError = message.Error;
                    }

                    if (!(System.Math.Abs(det) > 0) || nextError >= currentError)
                    {
                        neuralNetwork.SetWeights(prevW);
                        //Console.WriteLine("set to prev :");
                        //neuralNetwork.HiddenWeights.ForEach(Console.WriteLine);
                        mue *= mue_adj;
                        if (mue > max_mue)
                        {
                            mue = max_mue;
                            break;
                        }
                    }
                    else
                    {
                        mue /= mue_adj;
                        currentError = nextError;
                        //Console.WriteLine("the shit is here");
                        break;
                    }
                }
            }
        }

        private Tuple<Matrix<double>, Vector<double>> HissienAndGragient(NeuralNetwork.NeuralNetwork nn, Matrix<double> trainingSet, Matrix<double> trainingSetOutput)
        {
            var weights = nn.HiddenWeights;
            var layers = nn.Layers;
            List<Matrix<double>> gradient2D = new List<Matrix<double>>();
            for (int i = 0; i < weights.Count; ++i)
                gradient2D.Add(Matrix<double>.Build.Dense(layers[i + 1].NeuronsNumber, layers[i].NeuronsNumber + 1));
            Dictionary<int, List<double>> gradients = new Dictionary<int, List<double>>();
            List<double> errors = new List<double>();

            for (int i = 0; i < trainingSet.RowCount; i++)
            {
                //conpute gradient for one training example
                Vector<double> input = trainingSet.Row(i),
                    output = trainingSetOutput.Column(i);
                var temp = nn.ForwardInput(input);
                IList<Vector<double>> acs = temp.Item1, gs = temp.Item2;
                var D = (output - acs[acs.Count - 1]).PointwiseMultiply(gs[gs.Count - 1]).ToColumnMatrix();
                var deltaW = D * acs[acs.Count - 2].ToRowMatrix();
                gradient2D[weights.Count - 1] = deltaW;
                for (int j = layers.Count - 2; j > 0; j--)
                {
                    D = (nn.HiddenWeights[j].Transpose() * D).RemoveRow(0).PointwiseMultiply(gs[j - 1].ToColumnMatrix());
                    deltaW = D * acs[j - 1].ToRowMatrix();
                    gradient2D[j - 1] = deltaW;
                }
                //end

                //put the gradient in 1D list
                int m = i;
                gradients.Add(m, new List<double>());
                for (int j = 0; j < weights.Count; j++)
                {
                    gradient2D[j].Enumerate().ForEach(e => gradients[m].Add(e));
                }
                //end 

                //compute error for one training example
                var t = output - acs[acs.Count - 1];
                errors.Add(t.PointwiseMultiply(t).Sum() / 2);
                //end
            }

            //initialize jaccobian matrix
            Matrix<double> jac = Matrix<double>.Build.Dense(trainingSet.RowCount, gradients[0].Count);
            for (int i = 0; i < jac.RowCount; i++)
            {
                for (int k = 0; k < jac.ColumnCount; ++k)
                {
                    jac[i, k] = gradients[i][k];
                }
            }
            //end

            //errors vector
            var err = Vector<double>.Build.DenseOfEnumerable(errors.AsEnumerable());


            return new Tuple<Matrix<double>, Vector<double>>(jac.Transpose()*jac, jac.Transpose()*err);
        } 
    }
}
