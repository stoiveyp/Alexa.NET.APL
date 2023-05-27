using Newtonsoft.Json;

namespace Alexa.NET.APL.DataStore.PackageManager
{
    public class InstallationError:Request.Type.Request
    {
        public const string RequestType = "Alexa.DataStore.PackageManager.InstallationError";

        [JsonProperty("packageId")]
        public string PackageId { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("error")]
        public InstallationErrorDetail Error { get; set; }
    }
}
