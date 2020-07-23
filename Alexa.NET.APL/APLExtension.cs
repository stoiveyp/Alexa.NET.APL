using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class APLExtension
    {
        [JsonProperty("name",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Name { get; set; }

        [JsonProperty("uri",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Uri { get; set; }
    }
}