using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL.Extensions
{
    public class BackstackGoBackCommand:APLCommand
    {
        private readonly string _extensionName;

        public static BackstackGoBackCommand For(BackStack extension)
        {
            return new BackstackGoBackCommand(extension.Name);
        }

        public BackstackGoBackCommand(string extensionName)
        {
            _extensionName = extensionName;
        }

        public override string Type => $"{_extensionName}:GoBack";

        [JsonProperty("backType",NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(StringEnumConverter))]
        public BackTypeKind? BackType { get; set; }

        [JsonProperty("backValue",NullValueHandling = NullValueHandling.Ignore)]
        public object BackValue { get; set; }
    }
}