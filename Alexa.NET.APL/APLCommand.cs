using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    [JsonConverter(typeof(APLCommandConverter))]
    public abstract class APLCommand
    {
        [JsonProperty("type")]
        public abstract string Type { get; }

        [JsonProperty("when",NullValueHandling = NullValueHandling.Ignore)]
        public string When { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public int DelayMilliseconds { get; set; }
    }
}
