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
    }
}
