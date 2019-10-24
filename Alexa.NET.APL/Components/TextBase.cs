using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public abstract class TextBase : APLComponent
    {
        [JsonProperty("fontFamily", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FontFamily { get; set; }

        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Color { get; set; }
        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue FontSize { get; set; }
        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FontStyle { get; set; }
        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FontWeight { get; set; }
        [JsonProperty("letterSpacing", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue LetterSpacing { get; set; }
        [JsonProperty("lineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> LineHeight { get; set; }
        [JsonProperty("maxLines", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> MaxLines { get; set; }
        [JsonProperty("textAlign", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> TextAlign { get; set; }
        [JsonProperty("textAlignVertical", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> TextAlignVertical { get; set; }
    }
}