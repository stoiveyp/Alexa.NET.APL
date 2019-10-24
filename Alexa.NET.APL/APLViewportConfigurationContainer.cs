using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class APLViewportConfigurationContainer
    {
        [JsonProperty("current",NullValueHandling = NullValueHandling.Ignore)]
        public APLViewportConfiguration Current { get; set; }
    }
}