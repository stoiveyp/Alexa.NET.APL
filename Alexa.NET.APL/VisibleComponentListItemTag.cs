using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class VisibleComponentListItemTag
    {
        [JsonProperty("index",NullValueHandling = NullValueHandling.Ignore)]
        public int? Index { get; set; }
    }
}