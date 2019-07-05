using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaOrdinal:APLComponent
    {
        [JsonProperty("type")] public override string Type => nameof(AlexaOrdinal);

        [JsonProperty("ordinalText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> OrdinalText { get; set; }

        [JsonProperty("theme",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }
    }
}
