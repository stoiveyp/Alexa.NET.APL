using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaTextWrapping:ResponsiveTemplate
    {
        public override string Type => nameof(AlexaTextWrapping);

        [JsonProperty("buttonStyle",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ButtonStyle { get; set; }

        [JsonProperty("buttonText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ButtonText { get; set; }

        [JsonProperty("headerTitleCanUseTwoLines",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> HeaderTitleCanUseTwoLines { get; set; }

        [JsonProperty("primaryText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> PrimaryText { get; set; }

        [JsonProperty("secondaryText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SecondaryText { get; set; }

        [JsonProperty("tertiaryText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> TertiaryText { get; set; }

        [JsonProperty("primaryAction", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

        [JsonProperty("touchForward",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> TouchForward { get; set; }
    }
}
