using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class VisibleComponent
    {
        [JsonProperty("id",NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("uid",NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        [JsonProperty("position",NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        [JsonProperty("type",NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public VisibleComponentTags Tags { get; set; }

        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public VisibleComponent[] Children { get; set; }

        [JsonProperty("entities",NullValueHandling = NullValueHandling.Ignore)]
        public VisibleComponentEntity[] Entities { get; set; }
    }
}