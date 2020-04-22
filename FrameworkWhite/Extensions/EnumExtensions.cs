using System;
using System.ComponentModel;
using System.Linq;

namespace FrameworkWhite.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var attributes = (DescriptionAttribute[])(value.GetType().GetField(value.ToString())).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.FirstOrDefault()?.Description ?? value.ToString();
        }
    }
}
