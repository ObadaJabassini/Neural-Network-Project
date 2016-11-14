using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworkProject.DataAdapter;
using NeuralNetworkProject.Math;
using NeuralNetworkProject.NeuralNetwork;
using Telerik.WinControls.UI;
using Telerik.Windows.Diagrams.Core;
using Point = Telerik.Windows.Diagrams.Core.Point;

namespace NeuralNetworkProject.GUI
{
    static class Controller
    {
        public static bool ParseFile()
        {
           
            return true;
        }

        public static void CreateNet(FlowLayoutPanel layers, FileDialog LoadData_dlg, Telerik.WinControls.UI.RadDiagram radDiagram1,Result r)
        {
            Training.Trainer trainer = new Training.Trainer();
            trainer.Subscribe(r);
            List<Layer> layersent=new List<Layer>();
            Layer_ctrl temp;
            int neuronsnumber;
            //ActivatorFunctions.FunctionName applier ;
            NeuralNetwork.NeuralNetworkBuilder b = new NeuralNetwork.NeuralNetworkBuilder();
            
            foreach (var layer  in layers.Controls)
            {
                temp= layer as Layer_ctrl;
                neuronsnumber = Convert.ToInt16(temp.numericUpDown1.Value);

                //if (ActivatorFunctions.FunctionName.SIGMOID.ToString() == temp.AF_drpdn.SelectedItem.Text)
                //    applier = ActivatorFunctions.FunctionName.SIGMOID;
                 b.Layer( neuronsnumber,new Math.FunctionApplier());
            }
            NeuralNetwork.NeuralNetwork nn=b.Build();
            string FileName = LoadData_dlg.FileName;

            var tuples = DataReader.DataReader.Instance.ReadFromFile(FileName);

            var inputs = tuples.Item1;
            var outputs = tuples.Item2;
            DataDivider Divider = new DataDivider();
            var temp2 = Divider.Divide(inputs, outputs);
            for (int i = 0; i < temp2.Item1.RowCount; i++)
            {
                //LoadData.Input_plt.Series[0].Points.AddXY(temp.Item1.);
                //temp.Item1[i, 0];
            }
            trainer.Train(nn, tuples.Item1, tuples.Item2);
            //// test case (should belong to the second class = [0 1 0])
            var tt = nn.ForwardInput(Vector<double>.Build.DenseOfArray(new double[] { 5.5, 2.5, 4.0, 1.3 }));
            //Console.WriteLine(tt.Item1[tt.Item1.Count - 1]);
            //Console.ReadLine();
            Graph_Training GraphTraining = new Graph_Training(nn);
            for(int i=0;i< nn.Layers.Count;i++)
            {
               radDiagram1.AddShape(new Layer_shape("Layer"+i+Layerinfo(nn.Layers[i])), null,new Point(i*  250,0));
            }
            Weight_edge edge;
            for(int i=1;i<radDiagram1.Shapes.Count;i++)
                {
                    
                   
                    radDiagram1.AddConnection((IShape)radDiagram1.Shapes[i-1], (IShape)radDiagram1.Shapes[i]);
                    radDiagram1.Connections[i - 1].TargetCapType = CapType.Arrow2Filled;
                    radDiagram1.Connections[i - 1].AllowDelete = false;
                    radDiagram1.Connections[i - 1].IsDraggingEnabled = false;
                    radDiagram1.Connections[i - 1].IsEditable = false;
                    radDiagram1.Connections[i - 1].TargetCapSize=new SizeF(20,25);
                    //I don't know how!!
                    RadDiagramConnection connection1 = (RadDiagramConnection) radDiagram1.Connections[i - 1];
                    //connection1.BackColor = Color.Crimson;
                   // connection1.BackColor = Color.LightCoral;
                    connection1.BackColor = Color.LightSalmon;
                    //connection1.BackColor = Color.Tomato;
                    //radDiagram1.Connections[i - 1].


                    //edge=new Weight_edge(radDiagram1,i);
                    //BackColor = Color.Gold;

                    //    radDiagram1.AddConnection(
                    //        radDiagram1,i
                    //        //new Weight_edge(
                    //        ////    (IShape)radDiagram1.Shapes[i],
                    //        ////(IShape)radDiagram1.Shapes[i - 1]
                    //)
                    //       // )

                    //        ;
                }
            
          
        }

        private static string Layerinfo(Layer layer)
        {
            return "\n\nNeuronsNumber :\n" +
                   layer.NeuronsNumber +
                   "\nLearningRate :\n" +
                   layer.LearningRate
                  // + "AF :\n" + layer.Applier.ActivatorFunction.ToString();
                ;
        }
    }
}
