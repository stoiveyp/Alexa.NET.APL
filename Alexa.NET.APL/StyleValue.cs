using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    public class StyleValue
    {
        public StyleValue() { }

        public StyleValue(Dictionary<string, object> properties)
        {
            Properties = properties;
        }


        [JsonProperty("when",NullValueHandling = NullValueHandling.Ignore)]
        public string When { get; set; }

        [JsonExtensionData]
        public Dictionary<string,object> Properties { get; set; }
    }
}