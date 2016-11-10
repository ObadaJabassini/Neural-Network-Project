using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.Math
{
    public class ActivatorFunctions
    {
        private ActivatorFunctions() { }
        public enum FunctionName {SIGMOID}
        public static IActivatorFunction CreateFunction(string functionName)
        {
            var modifiedName = functionName.ToLower();
            modifiedName = Char.ToUpper(modifiedName[0]) + modifiedName.Substring(1);
            return Activator.CreateInstance(Type.GetType($"NeuralNetworkProject.Math.{modifiedName}Function")) as IActivatorFunction;
        }

        public static IActivatorFunction CreateFunction(FunctionName functionName)
        {
            switch(functionName)
            {
                case FunctionName.SIGMOID:
                default:
                    return new SigmoidFunction();
            }
        }
    }
}
