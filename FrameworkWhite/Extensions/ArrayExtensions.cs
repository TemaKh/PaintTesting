using System;
using System.ComponentModel;
using System.Linq;

namespace FrameworkWhite.Extensions
{
    public static class ArrayExtensions
    {
        public static string GetDescriptionByAttribute(this Array values, string attribute)
        {
            string attributeValue = null;
            foreach (Enum value in values)
            {
                if (string.Equals(attribute, value.ToString()))
                {
                    var attributes = (DescriptionAttribute[])(value.GetType().GetField(value.ToString())).GetCustomAttributes(typeof(DescriptionAttribute), false);
                    attributeValue = attributes.FirstOrDefault()?.Description ?? value.ToString();
                }
            }
            return attributeValue;
        }
    }
}
