using Newtonsoft.Json;

namespace Alexa.NET.APL.DataStore.PackageManager
{
    public class UpdateRequest : Request.Type.Request
    {
        public const string RequestType = "Alexa.DataStore.PackageManager.UpdateRequest";

        [JsonProperty("fromVersion")]
        public string FromVersion { get; set; }

        [JsonProperty("toVersion")]
        public string ToVersion { get; set; }

        [JsonProperty("packageId")]
        public string PackageId { get; set; }
    }
}