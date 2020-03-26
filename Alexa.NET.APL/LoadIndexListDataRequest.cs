using Newtonsoft.Json;

namespace Alexa.NET.Request
{
    public class LoadIndexListDataRequest:Request.Type.Request
    {
        public const string RequestType = "Alexa.Presentation.APL.LoadIndexListData";

        [JsonProperty("token",NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("correlationToken",NullValueHandling = NullValueHandling.Ignore)]
        public string CorrelationToken { get; set; }

        [JsonProperty("listId",NullValueHandling = NullValueHandling.Ignore)]
        public string ListId { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
