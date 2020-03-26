using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alexa.NET.Request
{
    public class APLError
    {
        [JsonProperty("type",NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("reason",NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        [JsonProperty("message",NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonExtensionData]
        public Dictionary<string,object> ExtraData { get; set; }
    }
}