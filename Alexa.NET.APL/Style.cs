using System.Collections.Generic;
using System.Linq;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.Response.APL
{
    public class Style
    {
        [JsonProperty("extends")]
        public string Extends { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonIgnore()]
        public StyleValue Value
        {
            get => Values?.FirstOrDefault();
            set
            {
                Values = new List<StyleValue> {Value};
            }
        }

        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(StyleValueListConverter))]
        public IList<StyleValue> Values { get; set; }

        public bool ShouldSerializeValues()
        {
            return Values?.Any() ?? false;
        }
    }
}