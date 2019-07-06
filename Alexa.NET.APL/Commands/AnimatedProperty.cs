using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class AnimatedProperty
    {
        [JsonProperty("property",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Property { get; set; }

        [JsonProperty("from",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> From { get; set; }

        [JsonProperty("to",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> To { get; set; }
    }
}