using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class Sequential:APLCommand
    {
        public override string Type => nameof(Sequential);

        [JsonProperty("commands",NullValueHandling = NullValueHandling.Ignore)]
        public IList<APLCommand> Commands { get; set; }

        [JsonProperty("repeatCount",NullValueHandling = NullValueHandling.Ignore)]
        public int RepeatCount { get; set; }

    }
}
