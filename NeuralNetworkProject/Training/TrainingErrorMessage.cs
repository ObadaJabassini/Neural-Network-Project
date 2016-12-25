using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.Training
{
    public class TrainingErrorMessage
    {
        internal NeuralNetwork.NeuralNetwork NeuralNetwork { get; set; }
        internal Matrix<double> TrainingSet { get; set; }
        internal Matrix<double> CrossValidationSet { get; set; }
        internal Matrix<double> TrainingSetOutput { get; set; }
        internal Matrix<double> CrossValidationSetOutput { get; set; }
        internal double Error { get; set; } = 0;
        internal double TrainError { get; set; }
        internal double CrossError { get; set; }
        /**/
        internal int Epochs { get; set; }
    }
}
