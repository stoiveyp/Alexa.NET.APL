using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL.Commands
{
    public class SetState:APLCommand
    {
        public override string Type => nameof(SetState);

        [JsonProperty("componentId", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ComponentId { get; set; }

        [JsonProperty("state"),JsonConverter(typeof(StringEnumConverter))]
        public APLValue<SetStateStates> State { get; set; }

        [JsonProperty("value")]
        public APLValue<bool> Value { get; set; }
    }
}
