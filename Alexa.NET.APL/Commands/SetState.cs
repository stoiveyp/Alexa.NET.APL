using System;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    [Obsolete("This command is deprecated, and no longer the correct way to change state")]
    public class SetState:APLCommand
    {
        public override string Type => nameof(SetState);

        [JsonProperty("componentId", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ComponentId { get; set; }

        [JsonProperty("state"),JsonConverter(typeof(APLValueEnumConverter<SetStateStates>))]
        public APLValue<SetStateStates> State { get; set; }

        [JsonProperty("value")]
        public APLValue<bool> Value { get; set; }
    }
}
