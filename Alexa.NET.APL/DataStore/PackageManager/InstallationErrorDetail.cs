using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.DataStore.PackageManager
{
    public class InstallationErrorDetail
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("content",NullValueHandling = NullValueHandling.Ignore)]
        public JObject Content { get; set; }
    }
}