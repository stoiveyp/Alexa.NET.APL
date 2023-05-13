using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class VisibleComponentPagerTag
    {
        [JsonProperty("index",NullValueHandling = NullValueHandling.Ignore)]
        public int? Index { get; set; }

        [JsonProperty("page_count",NullValueHandling = NullValueHandling.Ignore)]
        public int? PageCount { get; set; }

        [JsonProperty("allow_forward",NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowForward { get; set; }

        [JsonProperty("allow_backwards",NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowBackwards { get; set; }
    }
}