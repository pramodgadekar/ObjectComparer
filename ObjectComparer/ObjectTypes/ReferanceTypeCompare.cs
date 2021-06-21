using ObjectComparer.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.ObjectTypes
{
    class ReferanceTypeCompare : ITypeCompare
    {
        public bool Compare<T>(T firstObj, T secondObj)
        {
            var objComp = new ClassInfo<T>();
            foreach(var item in objComp.Members)
            {
                var value1 = item.GetMemberValue(firstObj);
                var value2 = item.GetMemberValue(secondObj);
                if(!TypeCheck.GetTypeInstanace(value1, value2))
                {
                    return false;
                }
            }
                

            return true;
        }

    }
}
