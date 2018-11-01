using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class Scroll:APLCommand
    {
        public override string Type => nameof(Scroll);

        [JsonProperty("componentId",NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        [JsonProperty("distance",NullValueHandling = NullValueHandling.Ignore)]
        public int Distance { get; set; }
    }
}
