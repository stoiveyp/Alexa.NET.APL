using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class VisibleComponentListTag
    {
        [JsonProperty("item_count",NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemCount { get; set; }

        [JsonProperty("lowest_index_seen",NullValueHandling = NullValueHandling.Ignore)]
        public int? LowestIndexSeen { get; set; }

        [JsonProperty("highest_index_seen",NullValueHandling = NullValueHandling.Ignore)]
        public int? HighestIndexSeen { get; set; }

        [JsonProperty("lowest_ordinal_seen",NullValueHandling = NullValueHandling.Ignore)]
        public int? LowestOrdinalSeen { get; set; }

        [JsonProperty("highest_ordinal_seen",NullValueHandling = NullValueHandling.Ignore)]
        public int? HighestOrdinalSeen { get; set; }
    }
}