using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class VideoSource
    {
        [JsonProperty("url")]
        public APLValue<Uri> Uri { get; set; }

        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Description { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> DurationMilliseconds { get; set; }

        [JsonProperty("repeatCount", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> RepeatCount { get; set; }

        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Offset { get; set; }

        [JsonProperty("textTrack", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(GenericSingleOrListConverter<TextTrack>), true)]
        public APLValue<IList<TextTrack>> TextTrack { get; set; }

        public static List<VideoSource> FromUrl(string url)
        {
            return new List<VideoSource>{new VideoSource(url)};
        }

        public List<VideoSource> FromUrl(IEnumerable<string> urls)
        {
            return urls.Select(u => new VideoSource(u)).ToList();
        }

        public VideoSource()
        {
        }

        public VideoSource(string url)
        {
            Uri = new Uri(url);
        }
    }
}
