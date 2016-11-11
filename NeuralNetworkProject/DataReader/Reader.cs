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
                case "csv":
                    var lines = File.ReadAllLines(filePath);
                    string type = lines[0].Trim().ToLower();
                    lines = lines.Skip(1).ToArray();
                    Console.WriteLine(type);
                    if (type == "class")
                    {
                        Console.WriteLine("Arrived");
                        int maxClassified = -1;
                        char delimiter = lines[0].Contains(",") ? ',' : ' ';
                        var mat = Matrix<double>.Build.Random(lines.Length, lines[0].Split(delimiter).Length);
                        for (var i = 0; i < lines.Length; ++i)
                        {
                            var line = lines[i];
                            var arr = line.Split(delimiter).Select(element => Convert.ToDouble(element)).ToArray();
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
                        return new Tuple<Matrix<double>, Matrix<double>>(mat.InsertColumn(0, Vector<double>.Build.DenseOfEnumerable(Enumerable.Repeat(1, mat.RowCount).Select(r => Convert.ToDouble(r)))), output);
                    }
                    else
                    {
                        Console.WriteLine("arrived");
                        char delimiter = lines[0].Contains(",") ? ',' : ' ';
                        var mat = Matrix<double>.Build.Random(lines.Length, lines[0].Split(delimiter).Length);
                        for (var i = 0; i < lines.Length; ++i)
                        {
                            var line = lines[i];
                            var arr = line.Split(delimiter).Select(element => Convert.ToDouble(element)).ToArray();
                            mat.SetRow(i, arr);
                        }
                        Vector<double> output = mat.Column(mat.ColumnCount - 1);
                        mat = mat.RemoveColumn(mat.ColumnCount - 1);
                        return new Tuple<Matrix<double>, Matrix<double>>(mat, Matrix<double>.Build.DenseOfRowVectors(output));
                    }

                case "xml":
                    break;
            }
            throw new ArgumentException("Not supported file extension");
        }
    }
}
