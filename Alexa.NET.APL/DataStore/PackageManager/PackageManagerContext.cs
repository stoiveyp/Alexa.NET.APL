using Newtonsoft.Json;

namespace Alexa.NET.APL.DataStore.PackageManager
{
    public class PackageManagerContext
    {
        [JsonProperty("installedPackages", NullValueHandling = NullValueHandling.Ignore)]
        public InstalledPackage[] InstalledPackages { get; set; }
    }
}
