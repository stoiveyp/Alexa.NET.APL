using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    public class Layout
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parameters")]
        public IList<Parameter> Parameters { get; set; }
    }
}