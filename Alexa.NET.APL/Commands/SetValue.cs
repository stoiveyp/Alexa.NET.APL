using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class SetValue : APLCommand
    {
        [JsonProperty("type")]
        public override string Type => nameof(SetValue);

        [JsonProperty("componentId", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ComponentId { get; set; }

        [JsonProperty("property")]
        public APLValue<string> Property { get; set; }


        [JsonProperty("value")]
        public APLValue<object> Value { get; set; }
    }
}
