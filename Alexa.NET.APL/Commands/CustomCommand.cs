using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class CustomCommand:APLCommand
    {
        public CustomCommand() { }

        public CustomCommand(string type)
        {
            Type = type;
        }

        [JsonProperty("type")]
        public override string Type { get; }

        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Description { get; set; }

        [JsonProperty("parameters",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<Parameter>> Parameters { get; set; }

        [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> Commands { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> ParameterValues { get; set; }
    }
}
