using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaIconButton:APLComponent
    {
        public override string Type => "AlexaIconButton";

        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }

        [JsonProperty("buttonSize",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue ButtonSize { get; set; }

        [JsonProperty("buttonStyle",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ButtonStyle { get; set; }

        [JsonProperty("primaryAction",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<APLCommand> PrimaryAction { get; set; }

        [JsonProperty("vectorSource", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> VectorSource { get; set; }

    }
}
