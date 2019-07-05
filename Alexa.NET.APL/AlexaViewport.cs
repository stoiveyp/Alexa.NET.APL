using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.APL
{
    public class AlexaViewport
    {
        [JsonProperty("experiences")]
        public ViewportExperience[] Experiences { get; set; }

        [JsonProperty("currentPixelWidth")]
        public int CurrentPixelWidth { get; set; }

        [JsonProperty("currentPixelHeight")]
        public int CurrentPixelHeight { get; set; }

        [JsonProperty("dpi")]
        public int DPI { get; set; }

        [JsonProperty("pixelHeight")]
        public int PixelHeight { get; set; }

        [JsonProperty("pixelWidth")]
        public int PixelWidth { get; set; }

        [JsonProperty("touch")]
        public string[] Touch { get; set; }

        [JsonProperty("keyboard")]
        public string[] Keyboard { get; set; }

        [JsonProperty("shape"),JsonConverter(typeof(StringEnumConverter))]
        public ViewportShape Shape { get; set; }

        [JsonProperty("video")]
        public VideoSupport Video { get; set; }


    }
}