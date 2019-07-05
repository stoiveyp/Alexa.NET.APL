using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaTextListItem:APLComponent
    {
        [JsonProperty("type")] public override string Type => nameof(AlexaTextListItem);

        [JsonProperty("hideDivider",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool> HideDivider { get; set; }

        [JsonProperty("hideOrdinal",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool> HideOrdinal { get; set; }

        [JsonProperty("primaryAction",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLCommand>> PrimaryAction { get; set; }

        [JsonProperty("primaryText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> PrimaryText { get; set; }

        [JsonProperty("theme",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }
    }
}
