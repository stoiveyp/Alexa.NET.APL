using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class SetPage:APLCommand
    {
        [JsonProperty("type")]
        public override string Type => nameof(SetPage);

        [JsonProperty("componentId",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ComponentId { get; set; }

        [JsonProperty("position",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<SetPagePosition>))]
        public APLValue<SetPagePosition> Position { get; set; }

        [JsonProperty("value")]
        public APLValue<int> Value { get; set; }
    }
}
