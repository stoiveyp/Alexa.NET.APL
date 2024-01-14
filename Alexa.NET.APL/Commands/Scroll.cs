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
        public APLValue<string> ComponentId { get; set; }

        [JsonProperty("distance",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Distance { get; set; }

        [JsonProperty("targetDuration", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> TargetDuration { get; set; }
    }
}
