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
                //var baseMatrix = trainingSet.EnumerateRows().Zip(trainingSetOutput.EnumerateColumns(), (first, second) => new Tuple<Vector<double>, Vector<double>>(first, second)).Select(sample =>
                //{
                //    Vector<double> input = sample.Item1,
                //                   output = sample.Item2;
                //    var temp = neuralNetwork.ForwardInput(input);
                //    IList<Vector<double>> acs = temp.Item1, gs = temp.Item2;
                //    IList<double> localErrors = new List<double>();
                //    var D = (output - acs[acs.Count - 1]).PointwiseMultiply(gs[gs.Count - 1]).ToColumnMatrix();
                //    var deltaW = D * acs[acs.Count - 2].ToRowMatrix();
                //    IList<double> ers = new List<double>();
                //    for (int i = deltaW.RowCount - 1; i >= 0; --i)
                //    {
                //        for (int k = deltaW.ColumnCount - 1; k >= 0; --k)
                //        {
                //            ers.Add(-deltaW[i, k]);
                //        }
                //    }
                //    for (int k = layers.Count - 2; k > 0; k--)
                //    {
                //        D = (weights[k].Transpose() * D).RemoveRow(0).PointwiseMultiply(gs[k - 1].ToColumnMatrix());
                //        deltaW = D * acs[k - 1].ToRowMatrix();
                //        for (int i = deltaW.RowCount - 1; i >= 0; --i)
                //        {
                //            for (int v = deltaW.ColumnCount - 1; v >= 0; --v)
                //            {
                //                ers.Add(-deltaW[i, v]);
                //            }
                //        }
                //    }
                //    var t = output - acs[acs.Count - 1];
                //    return new Tuple<Vector<double>, double>(Vector<double>.Build.DenseOfEnumerable(ers), t.PointwiseMultiply(t).Sum() / 2);
                //});
                var baseMatrix = trainingSet.EnumerateRows().Zip(trainingSetOutput.EnumerateColumns(), (first, second) => new Tuple<Vector<double>, Vector<double>>(first, second)).Select(sample =>
                {
                    Vector<double> input = sample.Item1,
                                   output = sample.Item2;
                    var temp = neuralNetwork.ForwardInput(input);
                    IList<Vector<double>> acs = temp.Item1, gs = temp.Item2;
                    IList<Vector<double>> local = new List<Vector<double>>();
                    for (int pp = 0; pp < layers[layers.Count - 1].NeuronsNumber; pp++)
                    {
                        double delta = gs[gs.Count - 1][pp];
                        IList<Vector<double>> list = new List<Vector<double>>();
                        Vector<double> vec = delta * weights[weights.Count - 1].Row(pp) * gs[gs.Count - 2][pp];
                        list.Add(vec);
                        for (int mm = weights.Count - 2; mm >= 0; --mm)
                        {
                            vec = (weights[mm].Transpose() * vec).PointwiseMultiply(gs[mm]);
                            list.Add(vec);
                        }
                        list = list.Reverse().ToList();
                        IList<double> ers = new List<double>();
                        for (int i = list.Count - 1; i >= 0; i--)
                        {
                            var tt = list[i].PointwiseMultiply(acs[i]);
                            tt.Reverse().ToList().ForEach(ers.Add);
                        }
                        local.Add(Vector<double>.Build.DenseOfEnumerable(ers));
                    }
                    var t = output - acs[acs.Count - 1];
                    return new Tuple<Matrix<double>, Vector<double>>(Matrix<double>.Build.DenseOfRowVectors(local), t.PointwiseMultiply(t) / 2);
                });
                message.Epochs = epochs;
                int index = 0;
                var j = Matrix<double>.Build.Dense(trainingSet.RowCount * layers[layers.Count - 1].NeuronsNumber, layers[layers.Count - 1].NeuronsNumber);
                foreach(var mat in baseMatrix.Select(element => element.Item1))
                {
                    for (int i = 0; i < mat.RowCount; i++)
                    {
                        j.SetRow(index++, mat.Row(i));
                    }
                }
                var jTranspose = j.Transpose();
                var errors = Vector<double>.Build.Dense(baseMatrix.Select(element => element.Item2.Count).Sum());
                index = 0;
                foreach(var vec in baseMatrix.Select(element => element.Item2))
                {
                    for (int i = 0; i < vec.Count; i++)
                    {
                        vec[index++] = vec[i];
                    }
                }
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
