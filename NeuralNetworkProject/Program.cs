using MathNet.Numerics.LinearAlgebra;
using NeuralNetworkProject.DataAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworkProject
{
    class Program
    {
         [STAThread]
        public static void Main(string[] args)
        {
            //var t = DataReader.DataReader.Instance.ReadFromFile("D:/test.txt");
            //Training.Trainer trainer = new Training.Trainer();
            //IDataDivider divider = Dividers.CreateDivider(Dividers.DividerType.INDEXED);
            //var temp = divider.Divide(t.Item1, t.Item2, Enumerable.Range(0, t.Item1.RowCount * 6 / 10), Enumerable.Range(t.Item1.RowCount * 6 / 10 + 1, t.Item1.RowCount - 1));
            //IDataDivider divider = Dividers.CreateDivider(Dividers.DividerType.RANDOMIZED);
            //var temp = divider.Divide(t.Item1, t.Item2, 0.6);
            //Console.WriteLine(temp.Item1);
            //Console.WriteLine(temp.Item3);
            //NeuralNetwork.NeuralNetwork nn = new NeuralNetwork.NeuralNetworkBuilder().
            //                                                  Layer(4, new Math.FunctionApplier()).
            //                                                  Layer(5, new Math.FunctionApplier()).
            //                                                  Layer(3, new Math.FunctionApplier()).
            //                                                  Build();
            //trainer.Train(nn, t.Item1, t.Item2);
            // test case (should belong to the second class = [0 1 0])
            //var tt = nn.ForwardInput(Vector<double>.Build.DenseOfArray(new double[] { 5.5, 2.5, 4.0, 1.3 }));
            //Console.WriteLine(tt.Item1[tt.Item1.Count - 1]);

            //Console.ReadLine();

            //Startup Form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoadData());

            //var t = DataReader.DataReader.Instance.ReadFromFile(@"C:\Users\DELL\Desktop\Datasets\test.txt");
            //Training.Trainer trainer = new Training.Trainer() { };
             //NeuralNetwork.NeuralNetwork nn = new NeuralNetwork.NeuralNetworkBuilder().
             //                                                  Layer(4, new Math.FunctionApplier()).
             //                                                  Layer(5, new Math.FunctionApplier()).
             //                                                  Layer(3, new Math.FunctionApplier()).
             //                                                  Build();
             //trainer.Train(nn, t.Item1, t.Item2);
             //// test case (should belong to the second class = [0 1 0])
             //var tt = nn.ForwardInput(Vector<double>.Build.DenseOfArray(new double[] { 5.5, 2.5, 4.0, 1.3 }));
             //Console.WriteLine(tt.Item1[tt.Item1.Count - 1]);
             //Console.ReadLine();

        }
    }
}
