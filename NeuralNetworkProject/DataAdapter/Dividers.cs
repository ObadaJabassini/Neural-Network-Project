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
        public enum DividerType {STATIC, RANDOMIZED, INDEXED}
        public static IDataDivider CreateDivider(DividerType dividerType)
        {
            switch (dividerType)
            {
                case DividerType.STATIC:
                default:
                    return new StaticDivider();
                case DividerType.RANDOMIZED:
                    return new RandomizedDivider();
                case DividerType.INDEXED:
                    return new IndexedDivider();
            }
        }

        public static IDataDivider CreateDivider(string dividerTypeName)
        {
            var modifiedName = dividerTypeName.ToLower();
            modifiedName = Char.ToUpper(modifiedName[0]) + modifiedName.Substring(1);
            return Activator.CreateInstance(Type.GetType($"NeuralNetworkProject.DataAdapter.{modifiedName}Divider")) as IDataDivider;
        }
    }
}
