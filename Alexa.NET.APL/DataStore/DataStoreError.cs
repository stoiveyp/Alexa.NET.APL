using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.DataStore
{
    [JsonConverter(typeof(DataStoreErrorConverter))]
    public class DataStoreError
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}