using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.VectorGraphics.Filters
{
    public class DropShadow:IAVGFilter
    {
        [JsonProperty("type")] 
        public string Type => nameof(DropShadow);

        [JsonProperty("color",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Color { get; set; }

        [JsonProperty("horizontalOffset",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> HorizontalOffset { get; set; }

        [JsonProperty("radius",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Radius { get; set; }

        [JsonProperty("verticalOffset",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> VerticalOffset { get; set; }
    }
}
