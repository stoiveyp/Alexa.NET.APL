using System.Collections.Generic;
using System.Linq;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class Pager: ActionableComponent
    {
        public Pager() { }

        public Pager(params APLComponent[] items) : this((IEnumerable<APLComponent>)items) { }

        public Pager(IEnumerable<APLComponent> items)
        {
            Items = items.ToList();
        }

        public override string Type => nameof(Pager);

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<object>> Data { get; set; }

        [JsonProperty("firstItem", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<APLComponent>> FirstItem { get; set; }

        [JsonProperty("lastItem", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<APLComponent>> LastItem { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore), 
         JsonConverter(typeof(APLComponentListConverter))]
        public APLValue<IList<APLComponent>> Items { get; set; }

        [JsonProperty("initialPage",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> InitialPage { get; set; }

        [JsonProperty("navigation",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Navigation { get; set; }

        [JsonProperty("onPageChanged",NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnPageChanged { get; set; }

        [JsonProperty("handlePageMove", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLPageMoveConverter))]
        public APLValue<IList<APLPageMoveHandler>> HandlePageMove { get; set; }
    }
}
