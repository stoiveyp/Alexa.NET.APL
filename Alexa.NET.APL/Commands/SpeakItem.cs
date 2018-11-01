using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class SpeakItem:APLCommand
    {
        public override string Type => nameof(SpeakItem);

        [JsonProperty("align",NullValueHandling = NullValueHandling.Ignore)]
        public string Align { get; set; }

        [JsonProperty("componentId",NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        [JsonProperty("highlightMode",NullValueHandling = NullValueHandling.Ignore)]
        public string HighlightMode { get; set; }
    }
}
