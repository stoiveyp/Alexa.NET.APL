using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class Sequence : APLComponent
    {
        public Sequence() { }

        public Sequence(params APLComponent[] items) : this((IEnumerable<APLComponent>)items) { }

        public Sequence(IEnumerable<APLComponent> items)
        {
            Items = items.ToList();
        }

        public override string Type => nameof(Sequence);

        [JsonProperty("data",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Data { get; set; }

        [JsonProperty("scrollDirection",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ScrollDirection { get; set; }

        [JsonProperty("firstItem",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<APLComponent>> FirstItem { get; set; }

        [JsonProperty("lastItem", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<APLComponent>> LastItem { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<APLComponent>> Items { get; set; }

        [JsonProperty("numbered",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> Numbered { get; set; }
    }
}
