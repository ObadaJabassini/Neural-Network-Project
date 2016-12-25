using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworkProject.NeuralNetwork;
using Telerik.Windows.Diagrams.Core;
using Accord.Neuro;
using Accord.Neuro.Learning;

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
            //Func<Math.IActivatorFunction, IActivationFunction> to = (fun) =>
            //{
            //    if (fun is Math.SigmoidFunction)
            //        return new SigmoidFunction();
            //    if (fun is Math.IdentityFunction)
            //        return new IdentityFunction();
            //    return new SigmoidFunction();
            //};
            //IList<ActivationLayer> layers = new List<ActivationLayer>();
            //layers.Add(new ActivationLayer(neuralNetwork.HiddenWeights[0].RowCount, trainingSet.ColumnCount, to(neuralNetwork.Layers[0].Applier.ActivatorFunction)));
            //for (int i = 1; i < neuralNetwork.HiddenWeights.Count; i++)
            //{
            //    layers.Add(new ActivationLayer(neuralNetwork.HiddenWeights[i - 1].RowCount, trainingSet.ColumnCount, to(neuralNetwork.Layers[i].Applier.ActivatorFunction)));
            //}
            double maxError = 0.01, error = 5, lr = 0.01;
            int maxEpochs = 1000, epochs = 0;
            if (hyperParameters != null)
            {
                if (maxEpochs <= 0)
                    throw new ArgumentException("Max Epochs cannot be negative");
                if (maxError > 2 || maxError < 0)
                    throw new ArgumentException("Max error cannot be negative or very large");
                maxError = hyperParameters.MaxError;
                maxEpochs = hyperParameters.MaxEpochs;
                lr = hyperParameters.Lr;
            }
            ActivationNetwork network = new ActivationNetwork(new SigmoidFunction(2), trainingSet.ColumnCount, neuralNetwork.Layers.Select(x => x.NeuronsNumber).ToArray());
            LevenbergMarquardtLearning teacher = new LevenbergMarquardtLearning(network, true) { LearningRate = lr};
            TrainingErrorMessage message = new TrainingErrorMessage()
            {
                NeuralNetwork = neuralNetwork,
                TrainingSet = trainingSet,
                CrossValidationSet = crossValidationSet,
                TrainingSetOutput = trainingSetOutput,
                CrossValidationSetOutput = crossValidationSetOutput
            };
            int iterations = 1;
            double[][] inputs = new double[trainingSet.RowCount][],
                      crossInputs = new double[crossValidationSet.RowCount][],
                      outputs = new double[trainingSetOutput.RowCount][],
                      crossOutputs = new double[crossValidationSetOutput.RowCount][];
            for (int i = 0; i < trainingSet.RowCount; i++)
            {
                inputs[i] = new double[trainingSet.ColumnCount];
                for (int j = 0; j < trainingSet.ColumnCount; j++)
                {
                    inputs[i][j] = trainingSet[i, j];
                }
            }
            for (int i = 0; i < trainingSetOutput.RowCount; i++)
            {
                outputs[i] = new double[trainingSetOutput.ColumnCount];
                for (int j = 0; j < trainingSet.ColumnCount; j++)
                {
                    outputs[i][j] = trainingSetOutput[i, j];
                }
            }
            for (int i = 0; i < crossValidationSet.RowCount; i++)
            {
                crossInputs[i] = new double[crossValidationSet.ColumnCount];
                for (int j = 0; j < crossValidationSet.ColumnCount; j++)
                {
                    crossInputs[i][j] = crossValidationSet[i, j];
                }
            }
            for (int i = 0; i < crossValidationSetOutput.RowCount; i++)
            {
                crossOutputs[i] = new double[crossValidationSetOutput.ColumnCount];
                for (int j = 0; j < crossValidationSetOutput.ColumnCount; j++)
                {
                    crossOutputs[i][j] = crossValidationSetOutput[i, j];
                }
            }
            while (error > maxError && iterations++ <= maxEpochs)
            {
                message.Epochs = iterations;
                error = teacher.RunEpoch(inputs, outputs);
                message.TrainError = error;
                message.CrossError = teacher.ComputeError(crossInputs, crossOutputs);
                base.Notify(message);
            }

            //double mue = 0.001, mue_adj = 10, max_mue = 1e10;

            //base.Notify(message);

            //double currentError = message.Error;
            //while (currentError >= maxError && epochs++ < maxEpochs)
            //{
            //    message.Epochs = epochs;

            //    var temp = HissienAndGragient(neuralNetwork, trainingSet, trainingSetOutput);
            //    var hessien = temp.Item1;
            //    var gradient = temp.Item2;
            //    Matrix<double> blendingMatrix = Matrix<double>.Build.DenseDiagonal(hessien.RowCount, hessien.ColumnCount);
            //    var prevW = neuralNetwork.HiddenWeights.ToList();
            //    //Console.WriteLine("prev :");
            //    //prevW.ForEach(Console.WriteLine);
            //    double nextError = 100000;
            //    while (true)
            //    {
            //        var term = hessien + mue*blendingMatrix;
            //        var det = term.Determinant();

            //        if (System.Math.Abs(det) > 0)
            //        {
            //            var deltaW = term*gradient;
            //            neuralNetwork.UpdateWeightsFromVector(deltaW);
            //            //Console.WriteLine("updated :");
            //            //neuralNetwork.HiddenWeights.ForEach(Console.WriteLine);
            //            base.Notify(message);
            //            nextError = message.Error;
            //        }

            //        if (!(System.Math.Abs(det) > 0) || nextError >= currentError)
            //        {
            //            neuralNetwork.SetWeights(prevW);
            //            //Console.WriteLine("set to prev :");
            //            //neuralNetwork.HiddenWeights.ForEach(Console.WriteLine);
            //            mue *= mue_adj;
            //            if (mue > max_mue)
            //            {
            //                mue = max_mue;
            //                break;
            //            }
            //        }
            //        else
            //        {
            //            mue /= mue_adj;
            //            currentError = nextError;
            //            //Console.WriteLine("the shit is here");
            //            break;
            //        }
            //    }
            //}
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
