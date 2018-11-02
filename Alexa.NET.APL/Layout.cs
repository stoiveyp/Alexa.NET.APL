using System.Collections.Generic;
using System.Linq;
using Alexa.NET.APL;
using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    public class Layout:IAPLComponentChild
    {
        public Layout() { }

        public Layout(IEnumerable<APLComponent> items)
        {
            Items = items.ToList();
        }

        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Parameter> Parameters { get; set; }

        [JsonProperty("items")]
        public IList<APLComponent> Items { get; set; }
    }
}