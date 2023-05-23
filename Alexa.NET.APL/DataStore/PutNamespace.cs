using Newtonsoft.Json;

namespace Alexa.NET.APL.DataStore
{
    public class PutNamespace : DataStoreCommand
    {
        [JsonProperty("namespace")]
        public string Namespace { get; set; }
    }
}