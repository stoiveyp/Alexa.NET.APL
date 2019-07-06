using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class SetFocus : APLCommand
    {
        [JsonProperty("type")]
        public override string Type => nameof(SetFocus);

        [JsonProperty("componentId", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ComponentId { get; set; }
    }
}