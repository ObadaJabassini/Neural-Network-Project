using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.Training
{
    public class Trainer
    {
        public ITrainingAlgorithm TrainingAlgorithm { get; set; }
        public Tuple<IList<Matrix<double>>, IList<double>, IList<double>> Train(NeuralNetwork.NeuralNetwork neuralNetwork, Matrix<double> trainingSet, Matrix<double> crossValidationSet, Matrix<double> outputs)
        {
            return TrainingAlgorithm.Train(neuralNetwork, trainingSet, crossValidationSet, outputs);
        }
    }
}
