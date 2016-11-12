using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.GUI
{
    static class Controller
    {
        public static bool ParseFile()
        {
            if(LoadData.LoadData_dlg.CheckFileExists == false) return false;

            string FileName = LoadData.LoadData_dlg.FileName;
            var t = DataReader.DataReader.Instance.ReadFromFile(FileName);
            
            
            
            return true;
        }
    }
}
