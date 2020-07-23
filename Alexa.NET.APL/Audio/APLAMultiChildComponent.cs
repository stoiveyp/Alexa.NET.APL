using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Audio
{
    public abstract class APLAMultiChildComponent:APLAComponent
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(GenericSingleOrListConverter<object>))]
        public APLValue<IList<object>> Data { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLAComponentListConverter))]
        public APLValue<IList<APLAComponent>> Items { get; set; }
    }
}