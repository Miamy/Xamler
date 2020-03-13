using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Xml;

namespace XamlerModel.Classes.Helpers
{
    public static class XmlExtentions
    {
        public static string AttributesList(this XmlNode node)
        {
            var builder = new StringBuilder();
            if (node.Attributes != null)
            {
                foreach (XmlAttribute attribute in node.Attributes)
                {
                    builder.Append(attribute.Name + "=" + attribute.Value + ", ");
                }
            }
            var str = builder.ToString();
            if (str.Length > 2)
            {
                str = str.Substring(0, str.Length - 2);
            }
            return str;
        }
    }


    [ValueConversion(typeof(XmlNode), typeof(string))]

    public sealed class MethodToValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var methodName = parameter as string;
            if (value == null || methodName == null)
                return value;
            //var methodInfo = value.GetType().GetMethod(methodName, Array.Empty<Type>());
            //if (methodInfo == null)
            //    return value;
            if (methodName == "AttributesList")
            {
                var node = (XmlNode)value;
                return node.AttributesList();
            }

            //return methodInfo.Invoke(value, Array.Empty<object>());
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("MethodToValueConverter can only be used for one way conversion.");
        }
    }
}
