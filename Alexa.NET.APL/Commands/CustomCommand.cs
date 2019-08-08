using System;
using System.Collections.Generic;
using System.Text;
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

        [JsonExtensionData]
        public Dictionary<string, object> ParameterValues { get; set; }
    }
}
