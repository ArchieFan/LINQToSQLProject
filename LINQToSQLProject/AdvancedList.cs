using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToSQLProject
{

    internal class AdvancedList<T>
    {
        public AdvancedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                //Add(item);
            }
        }

        public static AdvancedList<T> ToAdvancedList<T>(IEnumerable<T> source)
        {
            return new AdvancedList<T>(source);
        }
    }
}
