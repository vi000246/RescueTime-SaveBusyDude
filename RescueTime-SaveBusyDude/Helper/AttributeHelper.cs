using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RescueTime_SaveBusyDude.Helper
{
    public static class AttributeHelper
    {
        public static int GetColumnIndex<T>(string propertyName)
        {
            var type = typeof(T);
            var property = type.GetProperty(propertyName);
            var attr = (ColumnIndexAttribute[])property.GetCustomAttributes(typeof(ColumnIndexAttribute), false);
            if (0 < attr.Length)
                return attr[0].Index;
            else
                throw new NullReferenceException(
                    typeof(T).Name+".GetColumnNumber() error: Attempt to retrieve the non-existent \"ColumnNumber\" attribute out of property \"" + propertyName + "\" in class "+typeof(T).Name+"! You must define it before using it.");
        }

        public static string GetColumnNameByIndex<T>(int index)
        {
            var type = typeof(T);
            PropertyInfo[] properties = typeof(T).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                var attr = (ColumnIndexAttribute[])property.GetCustomAttributes(typeof(ColumnIndexAttribute), false);
                if (0 < attr.Length && attr[0].Index == index)
                    return property.Name;
            }
            throw new NullReferenceException("Cannot find column name by index.");
        }
    }
}
