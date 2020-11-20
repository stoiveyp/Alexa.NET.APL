using System.Collections;
using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.APL.VectorGraphics.Filters;
using Newtonsoft.Json;

namespace Alexa.NET.APL.VectorGraphics
{
    [JsonConverter(typeof(AVGItemConverter))]
    public interface IAVGItem
    {
        [JsonProperty("type")]
        string Type { get; }

        [JsonProperty("filters",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<IAVGFilter>> Filters { get; set; }
    }
}