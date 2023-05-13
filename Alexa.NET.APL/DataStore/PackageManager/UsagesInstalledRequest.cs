using Newtonsoft.Json;

namespace Alexa.NET.Request
{
    public class UsagesInstalledRequest : Request.Type.Request
    {
        public const string RequestType = "Alexa.DataStore.PackageManager.UsagesInstalled";

        [JsonProperty("payload")]
        public UsagesInstalledPayload Payload { get; set; }
    }
}
