using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class ScrollToIndex:APLCommand
    {
        [JsonProperty("type")]
        public override string Type => nameof(ScrollToIndex);

        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<ItemAlignment>))]
        public APLValue<ItemAlignment?> Align { get; set; }

        [JsonProperty("componentId",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ComponentId { get; set; }

        [JsonProperty("index")]
        public APLValue<int> Index { get; set; }

        [JsonProperty("targetDuration", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> TargetDuration { get; set; }
    }
}
