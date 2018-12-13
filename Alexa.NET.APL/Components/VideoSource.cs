using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class VideoSource
    {
        [JsonProperty("url")]
        public APLValue<Uri> Uri { get; set; }

        [JsonProperty("description")]
        public APLValue<string> Description { get; set; }

        [JsonProperty("duration")]
        public APLValue<int> DurationMilliseconds { get; set; }

        [JsonProperty("repeatCount")]
        public APLValue<int> RepeatCount { get; set; }

        [JsonProperty("offset")]
        public APLValue<int> Offset { get; set; }

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
