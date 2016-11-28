using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometryClassLibrary;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworkProject.DataAdapter;
using NeuralNetworkProject.GUI.CostumControls;
using NeuralNetworkProject.GUI.GraphShapes;
using NeuralNetworkProject.Math;
using NeuralNetworkProject.NeuralNetwork;
using NeuralNetworkProject.Properties;
using NeuralNetworkProject.Training;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Diagrams.Core;
using Point = Telerik.Windows.Diagrams.Core.Point;

namespace NeuralNetworkProject.GUI
{
    static class Controller
    {
        public struct trainerParams
        {
            public NeuralNetwork.NeuralNetwork nn;
            public Tuple<Matrix<double>, Matrix<double>> Tuple;
        }

        private static trainerParams Params;
        private static List<Bitmap> imgs;

        public static void Initiate()
        {
            Params = new trainerParams();
            imgs = new List<Bitmap>();
        }
        public static void InitiateGraph(Telerik.WinControls.UI.RadDiagram radDiagram1)
        {
            radDiagram1.BackgroundGrid.Visibility = ElementVisibility.Hidden;
            radDiagram1.BackgroundPageGrid.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            radDiagram1.IsSnapToGridEnabled = false; radDiagram1.IsSnapToItemsEnabled = false;
            radDiagram1.SetLayout(Telerik.Windows.Diagrams.Core.LayoutType.Tree);
            radDiagram1.IsInformationAdornerVisible = false;
            TreeLayoutSettings currentLayoutSettings = new Telerik.Windows.Diagrams.Core.TreeLayoutSettings()
            {
                HorizontalSeparation = 120d,
                VerticalSeparation = 180d,
                UnderneathVerticalTopOffset = 50d,
                UnderneathHorizontalOffset = 230d,
                UnderneathVerticalSeparation = 40d,
                VerticalDistance = 10d,
            };
            radDiagram1.SetLayout(Telerik.Windows.Diagrams.Core.LayoutType.Tree, currentLayoutSettings);
        }


        public static trainerParams BuildNet(FlowLayoutPanel layers, FileDialog LoadData_dlg, Result r,Telerik.WinControls.UI.RadDiagram radDiagram1)
        {
            Training.Trainer trainer = new Training.Trainer();
            NeuralNetworkBuilder b = new NeuralNetworkBuilder();
            L_ctrl_mat temp;
            int neuronsnumber;
            IActivatorFunction AF = null;
            FunctionApplier functionApplier = new FunctionApplier();
            foreach (var layer in layers.Controls)
            {
                temp = layer as L_ctrl_mat;
                neuronsnumber = Convert.ToInt16(temp.NN_drpdn.Value);
                if (ActivatorFunctions.FunctionName.SIGMOID.ToString() == temp.AF_drpdn.SelectedItem.Text)
                {
                    AF = new SigmoidFunction();
                    imgs.Add(Resources.Layer__Sigmoid);
                }
                if (ActivatorFunctions.FunctionName.TANH.ToString() == temp.AF_drpdn.SelectedItem.Text)
                {
                    AF = new TanhFunction();
                    //
                    imgs.Add(Resources.Layer__Sigmoid);
                }
                functionApplier.ActivatorFunction = AF;
                b.Layer(neuronsnumber,functionApplier,(double)temp.Lr_drpdn.Value);
            }
            NeuralNetwork.NeuralNetwork nn = b.Build();
            string FileName = LoadData_dlg.FileName;
            var tuples = DataReader.DataReader.Instance.ReadFromFile(FileName);

            var inputs = tuples.Item1;
            var outputs = tuples.Item2;
            StaticDivider Divider = new StaticDivider();    
            var temp2 = Divider.Divide(inputs, outputs,.6,.3);
            //ActivatorFunctions.FunctionName applier ;
            
            //// test case (should belong to the second class = [0 1 0])
            //var tt = nn.ForwardInput(Vector<double>.Build.DenseOfArray(new double[] { 5.5, 2.5, 4.0, 1.3 }));
            Params = new trainerParams();
            Params.nn = nn;
            Params.Tuple = tuples;
            NetGraph(nn,radDiagram1);

            return (Params);
        }


        public static void NetGraph(NeuralNetwork.NeuralNetwork nn, Telerik.WinControls.UI.RadDiagram radDiagram1)
        {
            List<Feature_shape> featureShapes=new List<Feature_shape>();
            List<AF_shape> afShapes=new List<AF_shape>();
            double x = 0;
            double y = 90;
            radDiagram1.AddShape(new Input_shape(),null,new Point(x,y));
            for (int i = 0; i < nn.Layers.Count; i++)
            {
                 x = i*250 + 100;
                 y = 0;
                //nn.Layers[i].Applier.ToString();
                Point location = new Point(x,y);
                radDiagram1.AddShape(new Layer_shape("\n\t" + nn.Layers[i].NeuronsNumber,imgs[i])
                {
                    //Label = { Text ="Layer "+i , }
                   //LayerBitmap=imgs[i]
                    
                }
                    ,null, location);
                /**
                featureShapes.Add(new Feature_shape()
                {
                    Location = new Point(i * 250 + 100, 30),
                    Text = Convert.ToString(nn.Layers[i].NeuronsNumber)
                }
                  );
                /**
                afShapes.Add(new AF_shape()
                {
                    Location = new Point(i * 250 + 200, 75),
                    Text = Convert.ToString(nn.Layers[i].Applier)

                }
                );
                /**/
                //(radDiagram1.Shapes[radDiagram1.Shapes.Count-1] as Layer_shape).addnodes();
            }
            x = nn.Layers.Count*250 + 100;
            y = 90;
            radDiagram1.AddShape(new Output_shape(), null, new Point(x,y));
            Weight_edge edge;
            for (int i = 1; i < radDiagram1.Shapes.Count; i++)
            {
                    radDiagram1.AddConnection((IShape) radDiagram1.Shapes[i - 1], (IShape) radDiagram1.Shapes[i]);
                    radDiagram1.Connections[i - 1].TargetCapType = CapType.Arrow2Filled;
                    radDiagram1.Connections[i - 1].AllowDelete = false;
                    radDiagram1.Connections[i - 1].IsDraggingEnabled = false;
                    radDiagram1.Connections[i - 1].IsEditable = false;
                    radDiagram1.Connections[i - 1].TargetCapSize = new SizeF(20, 25);
                    //I don't know how!!
                    RadDiagramConnection connection1 = (RadDiagramConnection) radDiagram1.Connections[i - 1];
                    connection1.BackColor = Color.LightSalmon;
                    //    radDiagram1.AddConnection(
                    //        radDiagram1,i
                    //        //new Weight_edge(
                    //        ////    (IShape)radDiagram1.Shapes[i],
                    //        ////(IShape)radDiagram1.Shapes[i - 1]
                    //)
                    //       // )

                   //        ;
                
            }
            for(int i=0;i<featureShapes.Count;i++)
            {
                radDiagram1.AddShape(featureShapes[i]);
                //radDiagram1.AddShape(afShapes[i]);
                //radDiagram1.AddConnection((IShape) radDiagram1.Shapes[radDiagram1.Shapes.Count - 1],
                //   (IShape) radDiagram1.Shapes[radDiagram1.Shapes.Count - 2]);


            }
            
        }

        private static string Layerinfo(Layer layer)
        {
            return "\n\nNeuronsNumber :\n" +
                   layer.NeuronsNumber +
                   "\nLearningRate :\n" +
                   layer.LearningRate
               // + "AF :\n" +layer.Applier.ActivatorFunction;
                ;
        }
    }
}
