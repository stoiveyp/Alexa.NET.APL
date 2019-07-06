using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class ScrollView:APLComponent
    {
        public const string ComponentType = "ScrollView";
        public override string Type => ComponentType;

        public ScrollView() { }
        public ScrollView(APLComponent component)
        {
            Item = new List<APLComponent> {component};
        }

        public ScrollView(params APLComponent[] components) : this((IEnumerable<APLComponent>)components) { }

        public ScrollView(IEnumerable<APLComponent> components)
        {
            Item = new List<APLComponent>(components);
        }

        [JsonProperty("item",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLComponent>> Item { get; set; }

        [JsonProperty("onScroll", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnScroll { get; set; }
    }
}
