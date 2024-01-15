using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab5zad5
{
    public class Kopia
    {
        public static T Copy<T>(T source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "Nie można skopiować obiektu o wartości null.");
            }

            if (source is ICloneable cloneable)
            {
                return (T)cloneable.Clone();
            }

            Type type = source.GetType();
            if (type.IsValueType || type == typeof(string))
            {
                return source;
            }

            object copy = Activator.CreateInstance(type);
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (FieldInfo field in fields)
            {
                object originalValue = field.GetValue(source);
                object copiedValue = Copy(originalValue);
                field.SetValue(copy, copiedValue);
            }

            return (T)copy;
        }
    }
}
