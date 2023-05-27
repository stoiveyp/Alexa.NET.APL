using Newtonsoft.Json;

namespace Alexa.NET.APL.DataStore
{
    public class DataStoreErrorContent
    {
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }
    }
}