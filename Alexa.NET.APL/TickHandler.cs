using System.Collections.Generic;
using Alexa.NET.APL;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    public class TickHandler
    {
        [JsonProperty("when", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> When { get; set; }

        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Description { get; set; }

        [JsonProperty("minimumDelay",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int> MinimumDelay { get; set; }

        [JsonProperty("commands"),
         JsonConverter(typeof(APLCommandListConverter), true)]
        public APLValue<IList<APLCommand>> Commands { get; set; }
    }
}