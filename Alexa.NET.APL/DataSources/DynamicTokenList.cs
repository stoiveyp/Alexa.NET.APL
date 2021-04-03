using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Alexa.NET.APL.DataSources
{
    public class DynamicTokenList : APLDataSource
    {
        public const string DataSourceType = "dynamicTokenList";
        public override string Type => DataSourceType;

        [JsonProperty("listId")]
        public string ListId { get; set; }

        [JsonProperty("pageToken")]
        public string PageToken { get; set; }

        [JsonProperty("backwardPageToken",NullValueHandling = NullValueHandling.Ignore)]
        public string BackwardPageToken { get; set; }

        [JsonProperty("forwardPageToken",NullValueHandling = NullValueHandling.Ignore)]
        public string ForwardPageToken { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public IList<object> Items { get; set; } = new List<object>();

        public bool ShouldSerializeItems()
        {
            return Items?.Any() ?? false;
        }
    }
}