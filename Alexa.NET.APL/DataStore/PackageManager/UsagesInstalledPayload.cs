using Newtonsoft.Json;

namespace Alexa.NET.Request
{
    public class UsagesInstalledPayload
    {
        [JsonProperty("packageId")]
        public string PackageId { get; set; }

        [JsonProperty("packageVersion",NullValueHandling = NullValueHandling.Ignore)]
        public string PackageVersion { get; set; }

        [JsonProperty("usages")]
        public Usage[] Usages { get; set; }
    }
}