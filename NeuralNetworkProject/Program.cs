using NeuralNetworkProject.DataAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            var t = DataReader.DataReader.Instance.ReadFromFile("D:/test.txt");
            var temp = new DataDivider();
            var data = temp.Divide(t.Item1, t.Item2);
            Console.WriteLine(data.Item1);
            Console.WriteLine(data.Item2);
            Console.WriteLine(data.Item3);
            Console.WriteLine(data.Item4);
            Console.ReadLine();
        }
    }
}
