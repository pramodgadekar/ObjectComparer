using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.ObjectTypes
{
    interface ITypeCompare
    {
        bool Compare<T>(T firstObj, T secondObj);
    }
}
