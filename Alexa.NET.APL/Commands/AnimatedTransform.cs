using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class AnimatedTransform : AnimatedProperty
    {
        [JsonProperty("property")]
        public override APLValue<string> Property => "transform";

        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<APLTransform[]> From { get; set; }

        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<APLTransform[]> To { get; set; }
    }
}