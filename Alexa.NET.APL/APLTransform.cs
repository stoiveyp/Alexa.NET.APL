using Alexa.NET.APL;
using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    public class APLTransform
    {
        [JsonProperty("rotate",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> Rotate { get; set; }

        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> Scale { get; set; }

        [JsonProperty("scaleX", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> ScaleX { get; set; }

        [JsonProperty("scaleY", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> ScaleY { get; set; }

        [JsonProperty("skewX", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> SkewX { get; set; }

        [JsonProperty("skewY", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> SkewY { get; set; }

        [JsonProperty("translateX", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> TranslateX { get; set; }

        [JsonProperty("translateY", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> TranslateY { get; set; }
    }
}