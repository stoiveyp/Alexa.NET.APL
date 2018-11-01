using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class Pager:APLComponent
    {
        public override string Type => nameof(Pager);

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Data { get; set; }

        [JsonProperty("firstItem", NullValueHandling = NullValueHandling.Ignore)]
        public IList<APLComponent> FirstItem { get; set; }

        [JsonProperty("lastItem", NullValueHandling = NullValueHandling.Ignore)]
        public IList<APLComponent> LastItem { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public IList<APLComponent> Items { get; set; }

        [JsonProperty("initialPage",NullValueHandling = NullValueHandling.Ignore)]
        public int InitialPage { get; set; }

        [JsonProperty("navigation",NullValueHandling = NullValueHandling.Ignore)]
        public string Navigation { get; set; }
    }
}
