using System.Collections.Generic;
using Alexa.NET.APL.Filters;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class Image:APLComponent
    {
        public Image() { }

        public Image(params string[] sources)
        {
            Sources = sources;
        }

        public const string ComponentType = "Image";
        public override string Type => ComponentType;

        [JsonProperty("align",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Align { get; set; }

        [JsonProperty("borderRadius",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue BorderRadius { get; set; }

        [JsonProperty("overlayGradient",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<APLGradient> OverlayGradient { get; set; }

        [JsonProperty("overlayColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> OverlayColor { get; set; }

        [JsonProperty("scale",NullValueHandling = NullValueHandling.Ignore),JsonConverter(typeof(APLValueEnumConverter<Scale>))]
        public APLValue<Scale?> Scale { get; set; }

        [JsonProperty("sources",NullValueHandling = NullValueHandling.Ignore),JsonConverter(typeof(StringOrArrayConverter))]
        public APLValue<IList<string>> Sources{ get; set; }

        [JsonProperty("filters",NullValueHandling = NullValueHandling.Ignore),JsonConverter(typeof(ImageFilterListConverter))]
        public APLValue<IList<IImageFilter>> Filters { get; set; }
    }
}
