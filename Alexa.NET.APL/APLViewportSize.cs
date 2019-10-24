using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class APLViewportSize
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("pixelHeight")]
        public int PixelHeight { get; set; }

        [JsonProperty("pixelWidth")]
        public int PixelWidth { get; set; }
    }
}