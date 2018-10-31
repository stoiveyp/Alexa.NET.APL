using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    [JsonConverter(typeof(StyleValueConverter))]
    public class StyleValue:Dictionary<string,string>
    {
        public StyleValue() { }

        public StyleValue(IDictionary<string,string> dictionary) : base(dictionary) { }


        [JsonProperty("when",NullValueHandling = NullValueHandling.Ignore)]
        public string When { get; set; }
    }
}