using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.VectorGraphics.Filters
{
    [JsonConverter(typeof(IAVGFilterConverter))]
    public interface IAVGFilter
    {
        [JsonProperty("type")]
        string Type { get; }
    }
}
