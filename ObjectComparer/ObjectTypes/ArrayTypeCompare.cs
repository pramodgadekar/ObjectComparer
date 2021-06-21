using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.ObjectTypes
{
    class ArrayTypeCompare : ITypeCompare
    {
        public bool Compare<T>(T firstObj, T secondObj)
        {
            var list1 = ((IEnumerable<T>)firstObj).ToList();
            var list2 = ((IEnumerable<T>)secondObj).ToList();
            list1.Sort();
            list2.Sort();
            return list2.SequenceEqual(list1);
        }
    }
}
