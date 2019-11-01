using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.Request
{
    public class APLInterfaceRuntime
    {
        [JsonIgnore]
        public APLDocumentVersion MaxVersion
        {
            get => ToEnum(MaxVersionString);
            set => MaxVersionString = ToEnumString(typeof(APLDocumentVersion), value);
        }

        private static string ToEnumString(System.Type enumType, object type)
        {
            var name = Enum.GetName(enumType, type);
            var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetTypeInfo().GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).FirstOrDefault();
            return enumMemberAttribute?.Value ?? type.ToString();
        }

        private static APLDocumentVersion ToEnum(string str)
        {
            var enumType = typeof(APLDocumentVersion);
            if (string.IsNullOrWhiteSpace(str))
            {
                return APLDocumentVersion.Unknown;
            }

            foreach (var name in Enum.GetNames(enumType))

            {
                var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetTypeInfo().GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).FirstOrDefault();
                if (enumMemberAttribute != null && enumMemberAttribute.Value == str) return (APLDocumentVersion)Enum.Parse(enumType, name);
            }
            return APLDocumentVersion.Unknown;
        }


        [JsonProperty("maxVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxVersionString { get; set; }
    }
}