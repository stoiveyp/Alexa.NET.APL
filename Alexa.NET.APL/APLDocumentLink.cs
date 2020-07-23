using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class APLDocumentLink : APLDocumentReference
    {
        public APLDocumentLink(){}

        public APLDocumentLink(string source)
        {
            Source = source;
        }

        public override string Type => "Link";

        [JsonProperty("src",NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }
    }
}