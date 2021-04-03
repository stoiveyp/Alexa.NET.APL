using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Alexa.NET.Response
{
    public abstract class ListDataDirective : IDirective
    {
        [JsonProperty("type")]
        public abstract string Type { get; }

        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("correlationToken", NullValueHandling = NullValueHandling.Ignore)]
        public string CorrelationToken { get; set; }

        [JsonProperty("listId", NullValueHandling = NullValueHandling.Ignore)]
        public string ListId { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public IList<object> Items { get; set; } = new List<object>();

        public bool ShouldSerializeItems()
        {
            return Items?.Any() ?? false;
        }
    }
}