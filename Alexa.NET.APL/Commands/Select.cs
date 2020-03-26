using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class Select:APLCommand
    {
        public override string Type => "Select";

        [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> Commands { get; set; }

        [JsonProperty("otherwise", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> Otherwise { get; set; }

        [JsonProperty("data",NullValueHandling = NullValueHandling.Ignore)]
        public object[] Data { get; set; }
    }
}
