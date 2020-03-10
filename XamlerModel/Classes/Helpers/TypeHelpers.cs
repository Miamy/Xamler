using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Classes.Helpers
{
    public static class AssemblyExtentions
    {
        public static IEnumerable<Type> GetLoadableTypes(this Assembly assembly)
        {
            if (assembly == null)
                throw new ArgumentNullException(nameof(assembly));

            try
            {
                return assembly.GetExportedTypes();
            }
            catch (ReflectionTypeLoadException e)
            {
                return e.Types.Where(t => t != null);
            }
        }
    }


    public static class TypeExtentions
    {
        public static List<PropertyInfo> GetBindableProperties(this Type type)
        {
            var allProperties = type.GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance).Where(p => p.CanRead).ToList();
            if (allProperties == null)
            {
                return null;
            }

            var result = new List<PropertyInfo>();
            foreach (var current in allProperties)
            {
                if (BindableFound(type, current.Name))
                {
                    result.Add(current);
                }

            }
            return result.OrderBy(p => p.Name).ToList();
        }

        private static bool BindableFound(Type type, string name)
        {
            if (type == null)
            {
                return false;
            }
            var bindableProperty = type.GetField(name + "Property");
            if (bindableProperty != null)
            {
                return true;
            }

            return BindableFound(type.BaseType, name);
        }
    }

}
