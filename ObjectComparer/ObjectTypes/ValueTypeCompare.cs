using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.ObjectTypes
{
    class ValueTypeCompare : ITypeCompare
    {
        public bool Compare<T>(T firstObj, T secondObj)
        {
            return firstObj.ToString() == secondObj.ToString();
        }

    }
}
