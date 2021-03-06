﻿using MathNet.Numerics.LinearAlgebra;
using NeuralNetworkProject.DataAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuralNetworkProject.GUI;
using NeuralNetworkProject.NeuralNetwork;

namespace NeuralNetworkProject.Training
{
    public partial class Trainer : IObserver<TrainingErrorMessage>
    {
        private bool _isLeven = false;
        public TrainingAlgorithm TrainingAlgorithm { private get; set; } = TrainingAlgorithms.Use(TrainingAlgorithms.TrainingMethod.GD);

        //GUI :public get 
        public DataDivider Divider {  get; set; } = new DataDivider()
        {
            Divider = Dividers.CreateDivider(Dividers.DividerType.STATIC)
        };

        public IList<double> TrainingErrors { get; private set; } = new List<double>();
        public IList<double> CrossValidationErrors { get; private set; } = new List<double>();

        public void Train(NeuralNetwork.NeuralNetwork neuralNetwork, Matrix<double> inputs, Matrix<double> outputs, HyperParameters hyperParamters = null)
        {
            if (TrainingAlgorithm is LevenbergAlgorithm)
                _isLeven = true;
            else
                _isLeven = false;
            TrainingAlgorithm.Subscribe(this);
            var temp = Divider.Divide(inputs, outputs);
            Console.WriteLine(temp.Item1);
            Console.WriteLine(temp.Item2);
            _train(neuralNetwork, temp.Item1, temp.Item3, temp.Item2, temp.Item4,hyperParamters);
        }

        private void _train(NeuralNetwork.NeuralNetwork neuralNetwork, Matrix<double> trainingSet,
            Matrix<double> crossValidationSet, Matrix<double> trainingSetOutput, Matrix<double> crossValidationSetOutput, HyperParameters hyperParamters = null)
        {
            TrainingAlgorithm.Train(neuralNetwork, trainingSet, crossValidationSet, trainingSetOutput,
                crossValidationSetOutput,hyperParamters);
        }

        protected double computeError(Vector<double> outputs, Vector<double> realOutputs)
        {
            var temp = (outputs - realOutputs);
            return (temp.PointwiseMultiply(temp)).Sum()/2;
        }

        public void OnNext(TrainingErrorMessage value)
        {
            NeuralNetwork.NeuralNetwork neuralNetwork = value.NeuralNetwork;
            Matrix<double> trainingSet = value.TrainingSet,
                trainingSetOutput = value.TrainingSetOutput,
                crossValidationSet = value.CrossValidationSet,
                crossValidationSetOutput = value.CrossValidationSetOutput;
            //var error = trainingSet.EnumerateRows().Select(row =>
            //{
            //    var temp = neuralNetwork.ForwardInput(row);
            //    return temp.Item1[temp.Item1.Count - 1];
            //}).Zip(trainingSetOutput.EnumerateColumns(), (first, second) => computeError(first, second)).Sum();
            //TrainingErrors.Add(error);
            //CrossValidationErrors.Add(crossValidationSet.EnumerateRows().Select(row =>
            //{
            //    var temp = neuralNetwork.ForwardInput(row);
            //    return temp.Item1[temp.Item1.Count - 1];
            //}).Zip(crossValidationSetOutput.EnumerateColumns(), (first, second) => computeError(first, second)).Sum());
            //value.Error = error;
           if(_isLeven)
            {
                TrainingErrors.Add(value.TrainError);
                CrossValidationErrors.Add(value.CrossError);
                NotifyResults(new ResultMesssage(value.TrainError, value.CrossError, value.Epochs));
                return;
            }
            /*Trainer as observer*/
            double validationERR=0,trainingERR=0;
            //int epochsNUM=0;
            var Terror = trainingSet.EnumerateRows().Select(row =>
            {
                var temp = neuralNetwork.ForwardInput(row);
                return temp.Item1[temp.Item1.Count - 1];
            }).Zip(trainingSetOutput.EnumerateColumns(), (first, second) => computeError(first, second)).Sum();
            TrainingErrors.Add(Terror);
            trainingERR = Terror;
            var Verror =crossValidationSet.EnumerateRows().Select(row =>
            { 
                var temp = neuralNetwork.ForwardInput(row);
                //epochsNUM = temp.Item1.Count;
                return temp.Item1[temp.Item1.Count - 1];
            }).Zip(crossValidationSetOutput.EnumerateColumns(), (first, second) => computeError(first, second)).Sum();
            value.Error = Terror;
            CrossValidationErrors.Add(Terror);
             validationERR=Verror;
           Console.WriteLine("{0}\t{1}\t*****{2}",value.Epochs,validationERR,trainingERR);
            //Trainer as observer
            ResultMesssage messsage=new ResultMesssage(trainingERR,validationERR,value.Epochs);
            NotifyResults(messsage);
            /*Trainer as observer*/
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted() => _observers.ForEach(obs => obs.OnCompleted());
    }

    public partial class Trainer : IObservable<ResultMesssage>
    {
        
        private List<IObserver<ResultMesssage>> _observers = new List<IObserver<ResultMesssage>>();

        public IDisposable Subscribe(IObserver<ResultMesssage> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return null;
        }
        public void NotifyResults(ResultMesssage message) => _observers.ForEach(obs => obs.OnNext(message));
    }

}
