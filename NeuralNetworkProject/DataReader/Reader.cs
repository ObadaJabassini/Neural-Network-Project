using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.DataReader
{
    public class DataReader
    {
        public DataReader Reader { get; } = new DataReader();
        private DataReader() { }
        public Matrix<double> ReadFromFile(string filePath)
        {
            return null;
        }
    }
}
