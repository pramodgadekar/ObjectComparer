using ObjectComparer.ObjectTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public static class Comparer
    {
        public static bool AreSimilar<T>(T first, T second)
        {
            ITypeCompare instance = null;
            if (first == null && second == null)
                return true;

            if ((first == null || second == null))
                return false;

            return TypeCheck.GetTypeInstanace(first, second);
        }
    }
}
