using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class GridSequence:ActionableComponent
    {
        public override string Type => nameof(GridSequence);

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(GenericSingleOrListConverter<object>))]
        public APLValue<IList<object>> Data { get; set; }

        [JsonProperty("firstItem", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLComponent>> FirstItem { get; set; }

        [JsonProperty("lastItem", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLComponent>> LastItem { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLComponentListConverter))]
        public APLValue<IList<APLComponent>> Items { get; set; }

        [JsonProperty("childHeights",NullValueHandling = NullValueHandling.Ignore),
            JsonConverter(typeof(GenericSingleOrListConverter<APLDimensionValue>))]
        public APLValue<IList<APLDimensionValue>> ChildHeights { get; set; }

        [JsonProperty("childWidths", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(GenericSingleOrListConverter<APLDimensionValue>))]
        public APLValue<IList<APLDimensionValue>> ChildWidths { get; set; }

        [JsonProperty("numbered",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Numbered { get; set; }

        [JsonProperty("onScroll", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnScroll { get; set; }

        [JsonProperty("scrollDirection",NullValueHandling = NullValueHandling.Ignore),
            JsonConverter(typeof(APLValueEnumConverter<ScrollDirection>))]
        public APLValue<ScrollDirection?> ScrollDirection { get; set; }
    }
}
