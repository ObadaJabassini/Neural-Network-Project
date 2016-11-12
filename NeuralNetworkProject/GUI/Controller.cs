using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using NeuralNetworkProject.DataAdapter;

namespace NeuralNetworkProject.GUI
{
    static class Controller
    {
        public static bool ParseFile()
        {
            if(LoadData.LoadData_dlg.CheckFileExists == false) return false;

            string FileName = LoadData.LoadData_dlg.FileName;
            var tuples = DataReader.DataReader.Instance.ReadFromFile(FileName);

            var inputs = tuples.Item1;
            var outputs = tuples.Item2;
            DataDivider Divider=new DataDivider();
            var temp = Divider.Divide(inputs, outputs);
            for (int i = 0; i < temp.Item1.RowCount; i++)
            {
                //LoadData.Input_plt.Series[0].Points.AddXY(temp.Item1.);
                //temp.Item1[i, 0];
            }

            return true;
        }
    }
}
