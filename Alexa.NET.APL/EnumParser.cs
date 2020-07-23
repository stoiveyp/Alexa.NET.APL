using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using Alexa.NET.Response.APL;

namespace Alexa.NET.APL
{
    internal static class EnumParser
    {
        internal static string ToEnumString(System.Type enumType, object type)
        {
            var name = Enum.GetName(enumType, type);
            var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetTypeInfo().GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).FirstOrDefault();
            return enumMemberAttribute?.Value ?? type.ToString();
        }

        internal static T ToEnum<T>(string str, T defaultValue)
        {
            var enumType = typeof(T);
            if (string.IsNullOrWhiteSpace(str))
            {
                return defaultValue;
            }

            foreach (var name in Enum.GetNames(enumType))

            {
                var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetTypeInfo().GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).FirstOrDefault();
                if (enumMemberAttribute != null && enumMemberAttribute.Value == str) return (T)Enum.Parse(enumType, name);
            }
            return defaultValue;
        }
    }
}