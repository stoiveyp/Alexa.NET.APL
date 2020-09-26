using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    [JsonConverter(typeof(APLExtensionConverter))]
    public class APLExtension
    {
        [JsonProperty("name",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Name { get; set; }

        [JsonProperty("uri",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Uri { get; set; }
    }
}