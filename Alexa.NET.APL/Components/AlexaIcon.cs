using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaIcon:APLComponent
    {
        public override string Type => nameof(AlexaIcon);

        [JsonProperty("iconName",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> IconName { get; set; }

        [JsonProperty("iconSource",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> IconSource { get; set; }

        [JsonProperty("iconSize", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue IconSize { get; set; }

        [JsonProperty("iconColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> IconColor { get; set; }

        [JsonProperty("iconStyle",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> IconStyle { get; set; }

        [JsonProperty("lang",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Lang { get; set; }




    }
}
