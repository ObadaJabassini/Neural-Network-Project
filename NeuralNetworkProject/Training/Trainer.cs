using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.Training
{
    public class Trainer : IObserver<TrainingErrorMessage>
    {
        public TrainingAlgorithm TrainingAlgorithm { private get; set; }
        public IList<double> TrainingErrors { get; private set; } = new List<double>();
        public IList<double> CrossValidationErrors { get; private set; } = new List<double>();
        public Tuple<IList<IList<Matrix<double>>>, IList<double>, IList<double>> Train(NeuralNetwork.NeuralNetwork neuralNetwork, Matrix<double> trainingSet, Matrix<double> crossValidationSet, Matrix<double> trainingSetOutput, Matrix<double> crossValidationSetOutput)
        {
            TrainingAlgorithm.Subscribe(this);
            return TrainingAlgorithm.Train(neuralNetwork, trainingSet, crossValidationSet, trainingSetOutput, crossValidationSetOutput);
        }

        protected double computeError(Vector<double> outputs, Vector<double> realOutputs)
        {
            var temp = (outputs - realOutputs);
            return (temp.PointwiseMultiply(temp)).Sum() / 2;
            // or
            //return (temp * temp.ToColumnMatrix())[0] / 2;
        }

        public void OnNext(TrainingErrorMessage value)
        {
            NeuralNetwork.NeuralNetwork neuralNetwork = value.NeuralNetwork;
            Matrix<double> trainingSet = value.TrainingSet, trainingSetOutput = value.TrainingSetOutput, crossValidationSet = value.CrossValidationSet, crossValidationSetOutput = value.CrossValidationSetOutput;
            var error = trainingSet.EnumerateRows().Zip(trainingSetOutput.EnumerateRows(), (first, second) => computeError(first, second)).Sum();
            TrainingErrors.Add(error);
            CrossValidationErrors.Add(crossValidationSet.EnumerateRows().Zip(crossValidationSetOutput.EnumerateRows(), (first, second) => computeError(first, second)).Sum());
            value.Error = error;
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            
        }
    }
}
