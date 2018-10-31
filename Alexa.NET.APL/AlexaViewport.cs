using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.APL
{
    public class AlexaViewport
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("dpi")]
        public int DPI { get; set; }

        [JsonProperty("pixelHeight")]
        public int PixelHeight { get; set; }

        [JsonProperty("pixelWidth")]
        public int PixelWidth { get; set; }

        [JsonProperty("shape"),JsonConverter(typeof(StringEnumConverter))]
        public ViewportShape Shape { get; set; }

        [JsonProperty("theme"), JsonConverter(typeof(StringEnumConverter))]
        public ViewportTheme Theme { get; set; }


    }
}