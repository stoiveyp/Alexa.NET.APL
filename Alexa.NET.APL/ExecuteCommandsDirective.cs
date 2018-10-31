using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.APL;
using Alexa.NET.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.Response
{
    public class ExecuteCommandsDirective:IDirective
    {
        public ExecuteCommandsDirective() { }

        public ExecuteCommandsDirective(string token)
        {
            Token = token;
        }

        public ExecuteCommandsDirective(string token, IEnumerable<APLCommand> commands):this(token)
        {
            Commands = commands.ToList();
        }

        [JsonProperty("type")]
        public string Type => "Alexa.Presentation.APL.ExecuteCommands";

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("commands")]
        public IList<APLCommand> Commands { get; set; }
    }
}
