using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class AutoPage:APLCommand
    {
        public override string Type => nameof(AutoPage);

        [JsonProperty("componentId",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ComponentId { get; set; }

        [JsonProperty("count",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Count { get; set; }

        [JsonProperty("duration",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Duration { get; set; }

        [JsonProperty("transitionDuration", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> TransitionDuration { get; set; }
    }
}
