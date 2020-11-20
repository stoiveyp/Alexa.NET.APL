using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaSwitch : APLComponent
    {
        [JsonProperty("type")]
        public override string Type => nameof(AlexaSwitch);

        [JsonProperty("primaryAction", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }

        [JsonProperty("activeColor", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ActiveColor { get; set; }

        [JsonProperty("switchHeight", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue SwitchHeight { get; set; }

        [JsonProperty("switchWidth", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue SwitchWidth { get; set; }
    }
}