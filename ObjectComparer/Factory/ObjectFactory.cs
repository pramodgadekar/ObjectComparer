using System;
using ObjectComparer.Common;
using ObjectComparer.ObjectTypes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.Factory
{
    class ObjectFactory
    {
        internal static ITypeCompare GetInstance(string typeName)
        {
            ITypeCompare instance = null;
            Type type = Type.GetType("ObjectComparer.ObjectTypes."+typeName);
            instance = (ITypeCompare)Activator.CreateInstance(type);

            //switch (typeName)
            //{
            //    case MagicWord.StringType:
            //        instance = new StringTypeCompare();
            //        break;
            //    case MagicWord.ValueType:
            //        instance = new ValueTypeCompare();
            //        break;
            //    default:
            //        instance = new DefaultTypeCompare();
            //        break;
            //}

            return instance;
        }
    }
}
