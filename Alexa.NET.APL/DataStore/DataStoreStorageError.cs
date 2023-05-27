using Newtonsoft.Json;

namespace Alexa.NET.APL.DataStore
{
    public class DataStoreStorageError : DataStoreError
    {
        [JsonProperty("content")]
        public DataStoreStorageErrorContent Content { get; set; }
    }
}