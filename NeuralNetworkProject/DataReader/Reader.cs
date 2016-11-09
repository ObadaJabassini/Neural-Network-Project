using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Complex;
using System;
using System.Collections.Generic;
using System.IO;
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
        public Tuple<Matrix<double>, Matrix<double>> ReadFromFile(string filePath)
        {
            switch (Path.GetExtension(filePath).Substring(1))
            {
                case "txt":
                    var lines = File.ReadAllLines(filePath);
                    int maxClassified = -1;
                    var mat = Matrix<double>.Build.Random(lines.Length, lines[0].Split(' ').Length);
                    for (var i = 0; i < lines.Length; ++i)
                    {
                        var line = lines[i];
                        var arr = line.Split(' ').Select(element => Convert.ToDouble(element)).ToArray();
                        maxClassified = (int)System.Math.Max(maxClassified, arr[arr.Length - 1]);
                        mat.SetRow(i, arr);
                   }
                    Vector<double> outputs = mat.Column(mat.ColumnCount - 1);
                    Matrix<double> output = Matrix<double>.Build.Random(lines.Length, maxClassified);
                    mat = mat.RemoveColumn(mat.ColumnCount - 1);
                    for (int i = 0; i < output.RowCount; i++)
                    {
                        double[] arr = new double[maxClassified];
                        arr[(int)outputs.At(i) - 1] = 1;
                        output.SetRow(i, Vector<double>.Build.Dense(arr));
                    }
                    return new Tuple<Matrix<double>, Matrix<double>>(mat, output);
                case "xml":
                    break;
            }
            throw new ArgumentException("Not supported file extension");
        }
    }
}
