using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.DataStore
{
    public class DataStoreErrorRequest: Request.Type.Request
    {
        public const string RequestType = "Alexa.DataStore.DataStoreError";

        [JsonProperty("error")]
        public DataStoreError Error { get; set; }
    }
}
