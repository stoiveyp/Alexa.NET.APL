using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class SpeakItem:APLCommand
    {
        [JsonProperty("type")]
        public override string Type => nameof(SpeakItem);

        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<ItemAlignment>))]
        public APLValue<ItemAlignment?> Align { get; set; }

        [JsonProperty("componentId",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ComponentId { get; set; }

        [JsonProperty("highlightMode",NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<HighlightMode>))]
        public APLValue<HighlightMode?> HighlightMode { get; set; }
    }
}
