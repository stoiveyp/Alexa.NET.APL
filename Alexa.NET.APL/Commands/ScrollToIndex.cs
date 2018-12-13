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
        public APLValue<string> Align { get; set; }

        [JsonProperty("componentId",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ComponentId { get; set; }

        [JsonProperty("index",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int> Index { get; set; }
    }
}
