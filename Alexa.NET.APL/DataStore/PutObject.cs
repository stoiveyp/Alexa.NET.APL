using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.DataStore
{
    public class PutObject : DataStoreCommand
    {
        [JsonProperty("content")]
        public JObject Content { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class PutObjectArray : DataStoreCommand
    {
        [JsonProperty("content")]
        public JObject[] Content { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }
}