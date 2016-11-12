using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworkProject.DataAdapter;

namespace NeuralNetworkProject.GUI
{
    static class Controller
    {
        public static bool ParseFile(FileDialog LoadData_dlg)
        {
            if (LoadData_dlg.CheckFileExists == false) return false;

            string FileName = LoadData_dlg.FileName;
            var tuples = DataReader.DataReader.Instance.ReadFromFile(FileName);

            var inputs = tuples.Item1;
            var outputs = tuples.Item2;
            DataDivider Divider = new DataDivider();
            var temp = Divider.Divide(inputs, outputs);
            for (int i = 0; i < temp.Item1.RowCount; i++)
            {
                //LoadData.Input_plt.Series[0].Points.AddXY(temp.Item1.);
                //temp.Item1[i, 0];
            }

            Training.Trainer trainer = new Training.Trainer() { };
            NeuralNetwork.NeuralNetwork nn = new NeuralNetwork.NeuralNetworkBuilder().
                                                              Layer(4, new Math.FunctionApplier()).
                                                              Layer(5, new Math.FunctionApplier()).
                                                              Layer(3, new Math.FunctionApplier()).
                                                              Build();
            trainer.Train(nn, tuples.Item1, tuples.Item2);
            //// test case (should belong to the second class = [0 1 0])
            var tt = nn.ForwardInput(Vector<double>.Build.DenseOfArray(new double[] { 5.5, 2.5, 4.0, 1.3 }));
            Console.WriteLine(tt.Item1[tt.Item1.Count - 1]);
            Console.ReadLine();


            return true;
        }
    }
}
