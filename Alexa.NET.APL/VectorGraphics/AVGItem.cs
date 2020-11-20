using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.APL.VectorGraphics.Filters;
using Newtonsoft.Json;

namespace Alexa.NET.APL.VectorGraphics
{
    public abstract class AVGItem:IAVGItem
    {
        [JsonProperty("type")]
        public abstract string Type { get; }

        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(AvgFilterListConverter))]
        public APLValue<IList<IAVGFilter>> Filters { get; set; }
    }
}
