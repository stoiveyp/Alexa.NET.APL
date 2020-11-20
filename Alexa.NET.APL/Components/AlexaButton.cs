using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaButton:APLComponent
    {
        [JsonProperty("type")]
        public override string Type => nameof(AlexaButton);

        [JsonProperty("buttonStyle",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ButtonStyle { get; set; }

        [JsonProperty("buttonText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ButtonText { get; set; }

        [JsonProperty("primaryAction",NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

        [JsonProperty("theme",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }

        [JsonProperty("touchForward",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> TouchForward { get; set; }
    }
}
