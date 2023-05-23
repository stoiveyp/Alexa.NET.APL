using Newtonsoft.Json;

namespace Alexa.NET.APL.DataStore
{
    public class DataStoreDeviceError : DataStoreError
    {
        [JsonProperty("content")]
        public DataStoreDeviceErrorContent Content { get; set; }
    }
}