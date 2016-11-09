﻿using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.DataReader
{
    public class DataReader
    {
        private static DataReader _reader = null;
        public static DataReader Instance
        {
            get
            {
                return _reader != null ? _reader : (_reader = new DataReader());
            }
        }
        private DataReader() { }
        public Matrix<double> ReadFromFile(string filePath)
        {
            return null;
        }
    }
}
