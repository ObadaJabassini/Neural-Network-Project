using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.Training
{
    class TrainingAlgorithms
    {
        public enum TrainingMethod { GD, GDM, LM}
        private TrainingAlgorithms() { }
        public static TrainingAlgorithm Use(TrainingMethod method)
        {
            switch (method)
            {
                case TrainingMethod.GD:
                default:
                    return new BackpropagationAlgorithm();
                case TrainingMethod.GDM:
                    return new BackPropagationWithMomentumAlgorithm();
                case TrainingMethod.LM:
                    return new LevenbergAlgorithm();
            }
        }

        public static TrainingAlgorithm Use(string method)
        {
            var modifiedName = method.ToLower();
            modifiedName = Char.ToUpper(modifiedName[0]) + modifiedName.Substring(1);
            return Activator.CreateInstance(Type.GetType($"NeuralNetworkProject.Training.{modifiedName}Algorithm")) as TrainingAlgorithm;
        }
    }
}
