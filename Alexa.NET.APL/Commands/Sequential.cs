using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class Sequential:APLCommand
    {
        public Sequential(IEnumerable<APLCommand> commands)
        {
            Commands = commands.ToList();
        }

        public Sequential(params APLCommand[] commands) : this((IEnumerable<APLCommand>)commands) { }

        public override string Type => nameof(Sequential);

        [JsonProperty("commands",NullValueHandling = NullValueHandling.Ignore)]
        public IList<APLCommand> Commands { get; set; }

        [JsonProperty("repeatCount",NullValueHandling = NullValueHandling.Ignore)]
        public int RepeatCount { get; set; }

    }
}
