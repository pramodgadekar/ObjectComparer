using ObjectComparer.Common;
using ObjectComparer.Extentions;
using ObjectComparer.Factory;
using ObjectComparer.ObjectTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    class TypeCheck
    {
        public static bool GetTypeInstanace<T>(T first, T second)
        {
            ITypeCompare instance = null;
            Type type = first.GetType();

            if (type.Name.StartsWith("String"))
                instance = ObjectFactory.GetInstance(MagicWord.StringType);
            else if (type.IsValueType && !type.IsArray)
                instance = ObjectFactory.GetInstance(MagicWord.ValueType);
            else if (type.IsArray)
                instance = ObjectFactory.GetInstance(MagicWord.ArrayType);
            else
                instance = ObjectFactory.GetInstance(MagicWord.ReferanceType);

            return instance != null && instance.Compare(first, second);
        }
    }
}
