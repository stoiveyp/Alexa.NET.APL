using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.Response
{
    public class RenderDocumentDirective:IDirective
    {
        [JsonProperty("type")]
        public string Type => "Alexa.Presentation.APL.RenderDocument";

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("document")]
        public APLDocument Document { get; set; }

        [JsonProperty("dataSources")]
        public Dictionary<string,object> DataSources { get; set; }
    }
}
