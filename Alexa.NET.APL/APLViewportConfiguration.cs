using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class APLViewportConfiguration
    {
        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public VideoSupport Video { get; set; }

        [JsonProperty("size",NullValueHandling = NullValueHandling.Ignore)]
        public APLViewportSize Size { get; set; }
    }
}