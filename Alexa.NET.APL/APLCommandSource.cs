using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class APLCommandSource
    {
        [JsonProperty("type",NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("handler",NullValueHandling = NullValueHandling.Ignore)]
        public string Handler { get; set; }

        [JsonProperty("id",NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }
    }
}
