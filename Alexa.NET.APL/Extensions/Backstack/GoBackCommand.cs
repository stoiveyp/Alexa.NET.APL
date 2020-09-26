using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL.Extensions.Backstack
{
    public class GoBackCommand:APLCommand
    {
        private readonly string _extensionName;

        public static GoBackCommand For(BackstackExtension extension)
        {
            return new GoBackCommand(extension.Name);
        }

        public GoBackCommand(string extensionName)
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