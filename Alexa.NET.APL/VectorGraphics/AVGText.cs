using Newtonsoft.Json;

namespace Alexa.NET.APL.VectorGraphics
{
    public class AVGText : IAVGItem
    {
        public string Type => "text";

        [JsonProperty("fontFamily", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FontFamily { get; set; }

        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> FontSize { get; set; }

        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FontStyle { get; set; }

        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FontWeight { get; set; }

        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> FillOpacity { get; set; }

        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Fill { get; set; }

        [JsonProperty("fillTransform",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FillTransform { get; set; }

        [JsonProperty("strokeOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> StrokeOpacity { get; set; }

        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Stroke { get; set; }

        [JsonProperty("strokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> StrokeWidth { get; set; }

        [JsonProperty("strokeTransform",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> StrokeTransform { get; set; }

        [JsonProperty("x",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> X { get; set; }

        [JsonProperty("y",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Y { get; set; }

        [JsonProperty("style",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Style { get; set; }

        [JsonProperty("text",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Text { get; set; }

        [JsonProperty("textAnchor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> TextAnchor { get; set; }

        [JsonProperty("letterSpacing",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> LetterSpacing { get; set; }
    }
}