using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL.Components
{
    public class Image:APLComponent
    {
        public Image() { }

        public Image(string source)
        {
            Source = source;
        }

        public const string ComponentType = "Image";
        public override string Type => ComponentType;

        [JsonProperty("align",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Align { get; set; }

        [JsonProperty("borderRadius",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue BorderRadius { get; set; }

        [JsonProperty("opacity",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Opacity { get; set; }

        [JsonProperty("overlayColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> OverlayColor { get; set; }

        [JsonProperty("scale",NullValueHandling = NullValueHandling.Ignore),JsonConverter(typeof(APLValueEnumConverter<ImageScale>))]
        public APLValue<ImageScale> Scale { get; set; }

        [JsonProperty("source",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Source { get; set; }
    }
}
