using System.Collections.Generic;
using System.Linq;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.Response.APL
{
    [JsonConverter(typeof(APLComponentConverter))]
    public abstract class APLComponent
    {
        [JsonProperty("type")]
        public abstract string Type { get; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("inheritParentState", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InheritParentState { get; set; }

        [JsonProperty("entity", NullValueHandling = NullValueHandling.Ignore)]
        public JToken Entity { get; set; }

        [JsonProperty("bind", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Binding> Bindings { get; set; }

        public bool ShouldSerializeBindings()
        {
            return Bindings?.Any() ?? false;
        }

        [JsonProperty("when", NullValueHandling = NullValueHandling.Ignore)]
        public string When { get; set; }

        [JsonProperty("style",NullValueHandling = NullValueHandling.Ignore)]
        public string StyleName { get; set; }

        [JsonProperty("paddingLeft", NullValueHandling = NullValueHandling.Ignore)]
        public string PaddingLeft { get; set; }

        [JsonProperty("paddingTop", NullValueHandling = NullValueHandling.Ignore)]
        public string PaddingTop { get; set; }

        [JsonProperty("paddingRight", NullValueHandling = NullValueHandling.Ignore)]
        public string PaddingRight { get; set; }

        [JsonProperty("paddingBottom", NullValueHandling = NullValueHandling.Ignore)]
        public string PaddingBottom { get; set; }

        [JsonProperty("minWidth", NullValueHandling = NullValueHandling.Ignore)]
        public string MinWidth { get; set; }

        [JsonProperty("minHeight", NullValueHandling = NullValueHandling.Ignore)]
        public string MinHeight { get; set; }

        [JsonProperty("maxWidth", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxWidth { get; set; }

        [JsonProperty("maxHeight", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxHeight { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public string Height { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public string Width { get; set; }

        [JsonProperty("alignSelf",NullValueHandling = NullValueHandling.Ignore)]
        public string AlignSelf { get; set; }

        [JsonProperty("bottom",NullValueHandling = NullValueHandling.Ignore)]
        public string Bottom { get; set; }

        [JsonProperty("grow",NullValueHandling = NullValueHandling.Ignore)]
        public int? Grow { get; set; }

        [JsonProperty("left",NullValueHandling = NullValueHandling.Ignore)]
        public string Left { get; set; }

        [JsonProperty("numbering",NullValueHandling = NullValueHandling.Ignore)]
        public string Numbering { get; set; }

        [JsonProperty("position",NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        [JsonProperty("right",NullValueHandling = NullValueHandling.Ignore)]
        public string Right { get; set; }

        [JsonProperty("shrink",NullValueHandling = NullValueHandling.Ignore)]
        public int? Shrink { get; set; }

        [JsonProperty("spacing",NullValueHandling = NullValueHandling.Ignore)]
        public string Spacing { get; set; }

        [JsonProperty("top",NullValueHandling = NullValueHandling.Ignore)]
        public string Top { get; set; }
    }
}