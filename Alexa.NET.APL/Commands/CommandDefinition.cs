using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class CommandDefinition
    {
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Description { get; set; }

        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<Parameter>> Parameters { get; set; }

        [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> Commands { get; set; }
    }
}