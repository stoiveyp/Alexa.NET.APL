using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaRadioButton:APLComponent
    {
        [JsonProperty("type")]
        public override string Type => nameof(AlexaRadioButton);

        [JsonProperty("primaryAction", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }

        [JsonProperty("radioButtonColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> RadioButtonColor { get; set; }

        [JsonProperty("radioButtonHeight",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue RadioButtonHeight { get; set; }

        [JsonProperty("radioButtonWidth", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue RadioButtonWidth { get; set; }
    }
}
