using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuralNetworkProject.NeuralNetwork;

namespace NeuralNetworkProject.Training
{
    public abstract class TrainingAlgorithm : IObservable<TrainingErrorMessage>
    {
        private List<IObserver<TrainingErrorMessage>> _observers = new List<IObserver<TrainingErrorMessage>> (); 
        public IDisposable Subscribe(IObserver<TrainingErrorMessage> observer)
        {
            this._observers.Add(observer);
            return null;
        }

        protected void Notify(TrainingErrorMessage message)
        {
            _observers.ForEach(obs => obs.OnNext(message));
        }

        protected void OnComplete()
        {
            _observers.ForEach(obs => obs.OnCompleted());
        }
        public abstract Tuple<IList<IList<Matrix<double>>>, IList<double>, IList<double>> Train(NeuralNetwork.NeuralNetwork neuralNetwork, Matrix<double> trainingSet, Matrix<double> crossValidationSet, Matrix<double> trainingSetOutput, Matrix<double> crossValidationSetOutput, HyperParameters hyperParamters = null);
    }
}
