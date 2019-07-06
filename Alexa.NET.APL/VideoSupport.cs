using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class VideoSupport
    {
        [JsonProperty("codecs")]
        public string[] Codecs { get; set; }
    }
}