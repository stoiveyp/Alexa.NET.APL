using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL.Audio
{
    public class Audio:APLAComponent
    {
        public override string Type => nameof(Audio);

        [JsonProperty("source",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Source { get; set; }

        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLAFilterListConverter))]
        public APLValue<IList<APLAFilter>> Filters { get; set; }
    }
}