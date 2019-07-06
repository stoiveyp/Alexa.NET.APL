using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class Sequential:APLCommand
    {
        public Sequential() { }
        public Sequential(IEnumerable<APLCommand> commands)
        {
            Commands = commands.ToList();
        }

        public Sequential(params APLCommand[] commands) : this((IEnumerable<APLCommand>)commands) { }

        public override string Type => nameof(Sequential);

        [JsonProperty("finally", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> Finally { get; set; }

        [JsonProperty("catch",NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> Catch { get; set; }

        [JsonProperty("commands"),
        JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> Commands { get; set; }

        [JsonProperty("repeatCount",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int> RepeatCount { get; set; }

    }
}
