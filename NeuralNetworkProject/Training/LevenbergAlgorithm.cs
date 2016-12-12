using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworkProject.NeuralNetwork;

namespace NeuralNetworkProject.Training
{
    class LevenbergAlgorithm : TrainingAlgorithm
    {
        internal LevenbergAlgorithm() { }
        public override void Train(NeuralNetwork.NeuralNetwork neuralNetwork, Matrix<double> trainingSet, Matrix<double> crossValidationSet, Matrix<double> trainingSetOutput, Matrix<double> crossValidationSetOutput, HyperParameters hyperParameters = null)
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
            var layers = neuralNetwork.Layers;
            var weights = neuralNetwork.HiddenWeights;
            var blendingFactor = 0.01;
            var adjustmentFactor = 10;
            TrainingErrorMessage message = new TrainingErrorMessage() { NeuralNetwork = neuralNetwork, TrainingSet = trainingSet, CrossValidationSet = crossValidationSet, TrainingSetOutput = trainingSetOutput, CrossValidationSetOutput = crossValidationSetOutput };
            while (error >= maxError && ++epochs <= maxEpochs)
            {
                var baseMatrix = trainingSet.EnumerateRows().Zip(trainingSetOutput.EnumerateColumns(), (first, second) => new Tuple<Vector<double>, Vector<double>>(first, second)).Select(sample =>
                {
                    Vector<double> input = sample.Item1,
                                   output = sample.Item2;
                    var temp = neuralNetwork.ForwardInput(input);
                    IList<Vector<double>> acs = temp.Item1, gs = temp.Item2;
                    IList<double> localErrors = new List<double>();
                    var D = (output - acs[acs.Count - 1]).PointwiseMultiply(gs[gs.Count - 1]).ToColumnMatrix();
                    var deltaW = D * acs[acs.Count - 2].ToRowMatrix();
                    IList<double> ers = new List<double>();
                    for (int i = deltaW.RowCount - 1; i >= 0; --i)
                    {
                        for (int k = deltaW.ColumnCount - 1; k >= 0; --k)
                        {
                            ers.Add(-deltaW[i, k]);
                        }
                    }
                    for (int k = layers.Count - 2; k > 0; k--)
                    {
                        D = (weights[k].Transpose() * D).RemoveRow(0).PointwiseMultiply(gs[k - 1].ToColumnMatrix());
                        deltaW = D * acs[k - 1].ToRowMatrix();
                        for (int i = deltaW.RowCount - 1; i >= 0; --i)
                        {
                            for (int v = deltaW.ColumnCount - 1; v >= 0; --v)
                            {
                                ers.Add(-deltaW[i, v]);
                            }
                        }
                    }
                    var t = output - acs[acs.Count - 1];
                    return new Tuple<Vector<double>, double>(Vector<double>.Build.DenseOfEnumerable(ers), t.PointwiseMultiply(t).Sum() / 2);
                });
                message.Epochs = epochs;
                var j = Matrix<double>.Build.DenseOfRows(baseMatrix.Select(element => element.Item1));
                var jTranspose = j.Transpose();
                var errors = Vector<double>.Build.DenseOfEnumerable(baseMatrix.Select(element => element.Item2));
                var prevWeights = neuralNetwork.HiddenWeights.Select(v => Matrix<double>.Build.DenseOfMatrix(v)).ToList();
                var currentError = 50000.0;
                var temp2 = jTranspose * j;
                var blendingMatrix = Matrix<double>.Build.DenseOfDiagonalVector(temp2.Diagonal());
                int m = 1;
                while (currentError >= error && m++ <= 5)
                {
                    neuralNetwork.SetWeights(prevWeights);
                    blendingFactor *= adjustmentFactor;
                    var deltaWeights = (temp2 + blendingFactor * blendingMatrix).Inverse() * jTranspose * errors;
                    neuralNetwork.UpdateWeightsFromVector(-deltaWeights);
                    base.Notify(message);
                    currentError = message.Error;
                }
                blendingFactor /= adjustmentFactor;
                error = currentError;
            }
        }
    }
}
