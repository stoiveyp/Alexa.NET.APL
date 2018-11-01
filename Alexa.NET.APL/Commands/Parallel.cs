using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class Parallel:APLCommand
    {
        public override string Type => nameof(Parallel);

        [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore)]
        public IList<APLCommand> Commands { get; set; }
    }
}
