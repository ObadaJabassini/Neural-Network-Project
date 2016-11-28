using MathNet.Numerics.LinearAlgebra;
using NeuralNetworkProject.DataAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworkProject.GUI.Forms;
using NeuralNetworkProject.Training;

namespace NeuralNetworkProject
{
    class Program
    {
         [STAThread]
        public static void Main(string[] args)
        {
            //var t = DataReader.DataReader.Instance.ReadFromFile("D:/test.txt");
            //Training.Trainer trainer = new Training.Trainer() { TrainingAlgorithm = TrainingAlgorithms.Use(TrainingAlgorithms.TrainingMethod.LM)};
            //IDataDivider divider = Dividers.CreateDivider(Dividers.DividerType.STATIC);
            //var temp = divider.Divide(t.Item1, t.Item2, 0.7);
            //NeuralNetwork.NeuralNetwork nn = new NeuralNetwork.NeuralNetworkBuilder().
            //                                                  Layer(4, new Math.FunctionApplier()).
            //                                                  Layer(5, new Math.FunctionApplier()).
            //                                                  Layer(3, new Math.FunctionApplier()).
            //                                                  Build();
            //trainer.Train(nn, t.Item1, t.Item2);
            ////test case (should belong to the second class = [0 1 0])
            //var tt = nn.ForwardInput(Vector<double>.Build.DenseOfArray(new double[] { 5.5, 2.5, 4.0, 1.3 }));


        //Console.WriteLine(tt.Item1[tt.Item1.Count - 1]);
        //Console.ReadLine();

        //Startup Form
        //Application.EnableVisualStyles();
        //Application.SetCompatibleTextRenderingDefault(false);
        //Application.Run(new LoadData());

            //Startup Form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CreateNN());
            
             //Application.Run(new LoadData());


    }
    }
}
