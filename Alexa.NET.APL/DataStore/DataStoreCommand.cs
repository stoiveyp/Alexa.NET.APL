using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.DataStore
{
    [JsonConverter(typeof(DataStoreCommandConverter))]
    public class DataStoreCommand
    {
        public DataStoreCommand(string type) => Type = type;

        [JsonProperty("type")]
        public string Type { get; }
    }
}