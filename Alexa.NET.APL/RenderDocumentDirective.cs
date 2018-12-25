using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.Response
{
    public class RenderDocumentDirective : IDirective
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type => "Alexa.Presentation.APL.RenderDocument";

        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("document")]
        public APLDocument Document { get; set; }

        [JsonProperty("datasources", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, APLDataSource> DataSources { get; set; }
    }
}
