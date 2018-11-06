using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    [JsonConverter(typeof(APLDataSourceConverter))]
    public abstract class APLDataSource
    {
        [JsonProperty("type")]
        public abstract string Type { get; }
    }
}