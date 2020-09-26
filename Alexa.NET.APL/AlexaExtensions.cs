using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class AlexaExtensions
    {
        [JsonProperty("available",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,object> Available { get; set; }
    }
}