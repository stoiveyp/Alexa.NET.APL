using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.DataStore
{
    public class PutObject : DataStoreCommand
    {
        [JsonProperty("content")]
        public JObject Content { get; set; }
    }
}