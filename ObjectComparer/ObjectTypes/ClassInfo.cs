using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.ObjectTypes
{
    internal class ClassInfo<T>
    {
        private List<MemberInfo> _members;
        public List<MemberInfo> Members => _members;
        public ClassInfo()
        {
            var properties = GetProperties(typeof(T), new List<Type>());
            var fields = typeof(T).GetTypeInfo().GetFields().Where(f => f.IsPublic).ToList();
            _members = properties.Union(fields.Cast<MemberInfo>()).ToList();
        }
       

        private List<PropertyInfo> GetProperties(Type type, List<Type> types)
        {
            var properties = type.GetTypeInfo().GetProperties().Where(p =>
               p.CanRead).ToList();
            types.Add(type);

            if (type.GetTypeInfo().IsInterface)
            {
                foreach (var parrentInterface in type.GetTypeInfo().GetInterfaces())
                {
                    if (types.Contains(parrentInterface))
                    {
                        continue;
                    }

                    properties = properties
                        .Union((IEnumerable<PropertyInfo>)GetProperties(parrentInterface, types))
                        .Distinct()
                        .ToList();
                }
            }

            return properties;
        }

       
    }
}
