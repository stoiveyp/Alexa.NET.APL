using System;
using System.Collections.Generic;
using System.Linq;
using Alexa.NET.APL;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    public class Layout
    {
        public Layout() { }

        public Layout(params APLComponent[] items) : this((IEnumerable<APLComponent>)items) { }

        public Layout(IEnumerable<APLComponent> items)
        {
            Items = items.ToList();
        }

        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(ParameterListConverter),true)]
        public IList<Parameter> Parameters { get; set; }

        [JsonProperty("items")]
        public IList<APLComponent> Items { get; set; }

        public Layout AsMain(string dataSourceKey = "payload")
        {
            if (Parameters == null)
            {
                Parameters = new List<Parameter>();
            }

            if (Parameters.All(p => string.Equals(p.Name, dataSourceKey, StringComparison.OrdinalIgnoreCase)))
            {
                Parameters.Add(new Parameter(dataSourceKey));
            }

            return this;
        }
    }
}