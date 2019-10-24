using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL
{
    public class APLViewport : Viewport
    {
        public override string Type => "APL";

        [JsonProperty("shape"), JsonConverter(typeof(StringEnumConverter))]
        public ViewportShape Shape { get; set; }

        [JsonProperty("dpi")]
        public int DPI { get; set; }

        [JsonProperty("presentationType")]
        public string PresentationType { get; set; }

        [JsonProperty("canRotate")]
        public bool CanRotate { get; set; }

        [JsonProperty("configuration")]
        public APLViewportConfigurationContainer Configuration { get; set; }
    }
}