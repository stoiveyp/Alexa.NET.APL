using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class Parallel:APLCommand
    {
        public Parallel() { }

        public Parallel(IEnumerable<APLCommand> commands)
        {
            Commands = commands.ToList();
        }

        public Parallel(params APLCommand[] commands) : this((IEnumerable<APLCommand>)commands) { }

        public override string Type => nameof(Parallel);

        [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore)]
        public IList<APLCommand> Commands { get; set; }
    }
}
