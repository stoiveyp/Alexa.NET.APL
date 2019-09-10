using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class AnimatedOpacity : AnimatedProperty
    {
        public AnimatedOpacity() { }

        public AnimatedOpacity(APLValue<double?> from, APLValue<double?> to)
        {
            From = from;
            To = to;
        }

        [JsonProperty("property")]
        public override APLValue<string> Property => "opacity";

        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> From { get; set; }

        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> To { get; set; }
    }
}