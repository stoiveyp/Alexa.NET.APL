using Newtonsoft.Json;

namespace Alexa.NET.APL.DataStore
{
    public class RemoveNamespace : DataStoreCommand
    {
        [JsonProperty("namespace")]
        public string Namespace { get; set; }
    }
}