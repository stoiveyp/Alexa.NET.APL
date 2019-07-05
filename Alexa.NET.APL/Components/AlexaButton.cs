using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaButton:APLComponent
    {
        [JsonProperty("type")]
        public override string Type => nameof(AlexaButton);

        [JsonProperty("accessibilityLabel",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> AccessibilityLabel { get; set; }

        [JsonProperty("buttonStyle",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ButtonStyle { get; set; }

        [JsonProperty("buttonText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ButtonText { get; set; }

        [JsonProperty("primaryAction",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLCommand>> PrimaryAction { get; set; }

        [JsonProperty("theme",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }
    }
}
