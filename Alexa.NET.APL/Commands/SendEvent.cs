using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class SendEvent:APLCommand
    {
        public override string Type => nameof(SendEvent);

        [JsonProperty("arguments", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<object>> Arguments { get; set; }

        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<string>> Components { get; set; }
    }
}
