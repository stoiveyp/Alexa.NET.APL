using System.Collections.Generic;
using System.Linq;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class Container:APLComponent
    {
        public Container() { }

        public Container(params APLComponent[] items) : this((IEnumerable<APLComponent>)items) { }

        public Container(IEnumerable<APLComponent> items)
        {
            Items = items.ToList();
        }

        [JsonProperty("type")]
        public override string Type => nameof(Container);
        
        [JsonProperty("alignItems",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> AlignItems { get; set; }

        [JsonProperty("data",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,object> Data { get; set; }

        [JsonProperty("direction",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Direction { get; set; }

        [JsonProperty("firstItem",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLComponent>> FirstItem { get; set; }

        [JsonProperty("lastItem",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLComponent>> LastItem { get; set; }

        [JsonProperty("items",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLComponent>> Items { get; set; }

        [JsonProperty("justifyContent",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> JustifyContent { get; set; }

        [JsonProperty("numbered",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> Numbered { get; set; }


    }
}
