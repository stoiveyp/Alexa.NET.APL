using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.Components;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.APL.Commands
{
    public class ControlMedia:APLCommand
    {
        [JsonProperty("type")]
        public override string Type => nameof(ControlMedia);

        [JsonProperty("command"),JsonConverter(typeof(APLValueEnumConverter<ControlMediaCommand>))]
        public APLValue<ControlMediaCommand> Command { get; set; }

        [JsonProperty("componentId", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ComponentId { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Value { get; set; }

    }
}
