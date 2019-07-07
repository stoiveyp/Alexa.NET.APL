using Newtonsoft.Json;

namespace Alexa.NET.Request
{
    public class APLInterfaceDetails
    {
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public APLInterfaceRuntime Runtime { get; set; }
    }
}