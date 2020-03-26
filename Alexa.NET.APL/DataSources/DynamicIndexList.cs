using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.Response.Directive;
using Newtonsoft.Json;

namespace Alexa.NET.APL.DataSources
{
    public class DynamicIndexList: APLDataSource
    {
        public DynamicIndexList() { }

        public DynamicIndexList(string listId, int startIndex = 0)
        {
            ListId = listId;
            StartIndex = startIndex;
        }

        public const string DataSourceType = "dynamicIndexList";
        public override string Type => DataSourceType;

        [JsonProperty("listId")]
        public string ListId { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("minimumInclusiveIndex",NullValueHandling = NullValueHandling.Ignore)]
        public int MinimumInclusiveIndex { get; set; }

        [JsonProperty("maximumExclusiveIndex",NullValueHandling = NullValueHandling.Ignore)]
        public int MaximumExclusiveIndex { get; set; }

        [JsonProperty("items",NullValueHandling = NullValueHandling.Ignore)]
        public IList<object> Items { get; set; } = new List<object>();

        public bool ShouldSerializeItems()
        {
            return Items?.Any() ?? false;
        }
    }
}
