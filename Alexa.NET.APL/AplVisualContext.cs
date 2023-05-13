using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class AplVisualContext
    {
        [JsonProperty("presentationUri",NullValueHandling = NullValueHandling.Ignore)]
        public string PresentationUri { get; set; }

        [JsonProperty("token",NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("version",NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("componentsVisibleOnScreen", NullValueHandling = NullValueHandling.Ignore)]
        public VisibleComponent[] ComponentsVisibleOnScreen { get; set; }
    }
}