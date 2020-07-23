using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public abstract class APLDocumentBase:APLDocumentReference
    {
        protected APLDocumentBase()
        {
            Version = APLDocumentVersion.V1;
        }

        protected APLDocumentBase(APLDocumentVersion version)
        {
            Version = version;
        }

        [JsonIgnore]
        public APLDocumentVersion Version
        {
            get => ToEnum(VersionString);
            set => VersionString = ToEnumString(typeof(APLDocumentVersion), value);
        }

        [JsonProperty("version")]
        public string VersionString { get; set; }

        [JsonProperty("layouts", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Layout> Layouts { get; set; }

        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Resource> Resources { get; set; }

        [JsonProperty("mainTemplate")]
        public Layout MainTemplate { get; set; }

        [JsonProperty("onMount", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter), true)]
        public APLValue<IList<APLCommand>> OnMount { get; set; }

        [JsonProperty("settings", NullValueHandling = NullValueHandling.Ignore)]
        public APLDocumentSettings Settings { get; set; }

        [JsonProperty("extensions",NullValueHandling = NullValueHandling.Ignore),
            JsonConverter(typeof(GenericSingleOrListConverter<APLExtension>))]
        public APLValue<IList<APLExtension>> Extensions { get; set; }

        private static string ToEnumString(System.Type enumType, object type)
        {
            var name = Enum.GetName(enumType, type);
            var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetTypeInfo().GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).FirstOrDefault();
            return enumMemberAttribute?.Value ?? type.ToString();
        }

        public static APLDocumentVersion ToEnum(string str)
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
    }
}
