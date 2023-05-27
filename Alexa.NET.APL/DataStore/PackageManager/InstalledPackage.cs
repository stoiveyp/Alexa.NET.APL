using Newtonsoft.Json;

namespace Alexa.NET.APL.DataStore.PackageManager
{
    public class InstalledPackage
    {
        [JsonProperty("packageId")]
        public string PackageId { get; set; }

        [JsonProperty("packageVersion")]
        public string PackageVersion { get; set; }
    }
}