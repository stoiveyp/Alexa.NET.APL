using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class Pager:APLComponent
    {
        public Pager() { }

        public Pager(params APLComponent[] items) : this((IEnumerable<APLComponent>)items) { }

        public Pager(IEnumerable<APLComponent> items)
        {
            Items = items.ToList();
        }

        public override string Type => nameof(Pager);

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Data { get; set; }

        [JsonProperty("firstItem", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLComponent>> FirstItem { get; set; }

        [JsonProperty("lastItem", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLComponent>> LastItem { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLComponent>> Items { get; set; }

        [JsonProperty("initialPage",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> InitialPage { get; set; }

        [JsonProperty("navigation",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Navigation { get; set; }
    }
}
