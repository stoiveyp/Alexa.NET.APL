using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class ScrollToIndex:APLCommand
    {
        public override string Type => nameof(ScrollToIndex);

        [JsonProperty("align",NullValueHandling = NullValueHandling.Ignore)]
        public string Align { get; set; }

        [JsonProperty("componentId",NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        [JsonProperty("index",NullValueHandling = NullValueHandling.Ignore)]
        public int Index { get; set; }
    }
}
