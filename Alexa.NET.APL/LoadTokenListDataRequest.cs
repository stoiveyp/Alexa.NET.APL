using Newtonsoft.Json;

namespace Alexa.NET.Request
{
    public class LoadTokenListDataRequest : Request.Type.Request
    {
        public const string RequestType = "Alexa.Presentation.APL.LoadTokenListData";

        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("correlationToken", NullValueHandling = NullValueHandling.Ignore)]
        public string CorrelationToken { get; set; }

        [JsonProperty("listId", NullValueHandling = NullValueHandling.Ignore)]
        public string ListId { get; set; }

        [JsonProperty("pageToken")]
        public string PageToken { get; set; }
    }
}