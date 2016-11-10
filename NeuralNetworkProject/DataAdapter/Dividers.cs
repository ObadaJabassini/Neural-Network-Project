using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.DataAdapter
{
    public class Dividers
    {
        private Dividers() { }
        public enum DividerType { STATIC}
        public static IDataDivider CreateDivider(DividerType dividerType)
        {
            switch(dividerType)
            {
                case DividerType.STATIC:
                default:
                    return new StaticDivider();
            }
        }
    }
}
