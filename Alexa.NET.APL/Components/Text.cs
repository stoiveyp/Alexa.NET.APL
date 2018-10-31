using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class Text:APLComponent
    {
        public const string ComponentType = "Text";
        public Text() { }

        public Text(string text)
        {
            Content = text;
        }
        public override string Type => ComponentType;

        [JsonProperty("text")]
        public string Content { get; set; }

        [JsonProperty("fontFamily")]
        public string FontFamily { get; set; }

        [JsonProperty("color",NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }
        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public string FontSize { get; set; }
        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string FontStyle { get; set; }
        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public string FontWeight { get; set; }
        [JsonProperty("letterSpacing", NullValueHandling = NullValueHandling.Ignore)]
        public string LetterSpacing { get; set; }
        [JsonProperty("lineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? LineHeight { get; set; }
        [JsonProperty("maxLines", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxLines { get; set; }
        [JsonProperty("textAlign", NullValueHandling = NullValueHandling.Ignore)]
        public string TextAlign { get; set; }
        [JsonProperty("textAlignVertical", NullValueHandling = NullValueHandling.Ignore)]
        public string TextAlignVertical { get; set; }
    }
}
