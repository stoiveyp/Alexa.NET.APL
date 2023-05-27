using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL
{
    public class VisibleComponentMediaTag
    {
        [JsonProperty("position_in_milliseconds",NullValueHandling = NullValueHandling.Ignore)]
        public int? PositionInMilliseconds { get; set; }

        [JsonProperty("allow_adjust_seek_position_forward",NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAdjustSeekPositionForward { get; set; }

        [JsonProperty("allow_adjust_seek_position_backwards",NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAdjustSeekPositionBackwards { get; set; }

        [JsonProperty("allow_next",NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowNext { get; set; }

        [JsonProperty("allow_previous",NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowPrevious { get; set; }

        [JsonProperty("url",NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("state",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public MediaTagState? State { get; set; }

        [JsonProperty("entities",NullValueHandling = NullValueHandling.Ignore)]
        public VisibleComponentEntity[] Entities { get; set; }
    }
}