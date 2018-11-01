using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class AutoPage:APLCommand
    {
        public override string Type => nameof(AutoPage);

        [JsonProperty("componentId",NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        [JsonProperty("count",NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        [JsonProperty("duration",NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }
    }
}
