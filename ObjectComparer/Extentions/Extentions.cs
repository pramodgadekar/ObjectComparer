using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.Extentions
{
    public static class Extentions
    {
      
        public static bool IsSimilar<T>(this T[] first, T[] second)
        {
            Array.Sort(first);
            Array.Sort(second);
            return first.SequenceEqual(second);
        }
        public static bool IsSimilar<T>(this List<T> first, List<T> second)
        {
            first.Sort();
            second.Sort();
            return first.SequenceEqual(second);
        }

        public static bool IsSimilar<TKey,TValue>(this Dictionary<TKey, TValue> first, Dictionary<TKey, TValue> second)
        {
            return first.OrderBy(pair => pair.Key)
               .SequenceEqual(second.OrderBy(pair => pair.Key));
        }

        public static object GetMemberValue(this MemberInfo memberInfo, object obj)
        {
            var propertyInfo = memberInfo as PropertyInfo;
            if (propertyInfo != null)
            {
                try
                {
                    return propertyInfo.GetValue(obj);
                }
                catch
                {
                    return null;
                }
            }

            var fieldInfo = memberInfo as FieldInfo;
            if (fieldInfo != null)
            {
                return fieldInfo.GetValue(obj);
            }

            return null;
        }
    }
}
