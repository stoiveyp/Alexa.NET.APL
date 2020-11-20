using System.Collections.Generic;
using Alexa.NET.APL;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    public class APLAction
    {
        [JsonProperty("name",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Name { get; set; }

        [JsonProperty("label",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Label { get; set; }

        [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> Commands { get; set; }
    }
}