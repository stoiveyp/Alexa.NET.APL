using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class Text:TextBase
    {
        public Text() { }

        public Text(string text)
        {
            Content = new APLValue<string>(text);
        }
        public override string Type => nameof(Text);

        [JsonProperty("text")]
        public APLValue<string> Content { get; set; }

        [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Lang { get; set; }
    }
}
