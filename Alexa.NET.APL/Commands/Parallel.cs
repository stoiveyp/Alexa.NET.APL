using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.APL.JsonConverter;
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

        [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> Commands { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(GenericSingleOrListConverter<object>))]
        public APLValue<IList<object>> Data { get; set; }
    }
}
