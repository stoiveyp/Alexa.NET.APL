using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class Text:APLComponent
    {
        public Text() { }

        public Text(string text)
        {
            Content = new APLValue<string>(text);
        }
        public override string Type => nameof(Text);

        [JsonProperty("text")]
        public APLValue<string> Content { get; set; }

        [JsonProperty("fontFamily")]
        public APLValue<string> FontFamily { get; set; }

        [JsonProperty("color",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Color { get; set; }
        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> FontSize { get; set; }
        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FontStyle { get; set; }
        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FontWeight { get; set; }
        [JsonProperty("letterSpacing", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> LetterSpacing { get; set; }
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
