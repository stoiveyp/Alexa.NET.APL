using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class SetPage:APLCommand
    {
        public override string Type => nameof(SetPage);

        [JsonProperty("componentId",NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        [JsonProperty("position",NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        [JsonProperty("value",NullValueHandling = NullValueHandling.Ignore)]
        public int Value { get; set; }
    }
}
