using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL
{
    public class APLGradient
    {
        [JsonProperty("type",NullValueHandling = NullValueHandling.Ignore),JsonConverter(typeof(StringEnumConverter))]
        public APLGradientType Type { get; set; }

        [JsonProperty("angle",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Angle { get; set; }

        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Description { get; set; }

        [JsonProperty("colorRange",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string[]> ColorRange { get; set; }

        [JsonProperty("inputRange",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double[]> InputRange { get; set; }
    }
}
