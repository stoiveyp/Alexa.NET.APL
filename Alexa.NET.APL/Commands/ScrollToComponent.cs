using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class ScrollToComponent : APLCommand
    {
        [JsonProperty("align",NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<ItemAlignment>))]
        public APLValue<ItemAlignment> Align { get; set; }

        [JsonProperty("componentId",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ComponentId { get; set; }

        [JsonProperty("type")]
        public override string Type => nameof(ScrollToComponent);
    }
}