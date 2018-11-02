using System.Collections.Generic;
using System.Linq;
using Alexa.NET.APL;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.Response.APL
{
    [JsonConverter(typeof(APLComponentConverter))]
    public abstract class APLComponent:IAPLComponentChild
    {
        [JsonProperty("type")]
        public abstract string Type { get; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("inheritParentState", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> InheritParentState { get; set; }

        [JsonProperty("bind", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Binding> Bindings { get; set; }

        public bool ShouldSerializeBindings()
        {
            return Bindings?.Any() ?? false;
        }

        [JsonProperty("when", NullValueHandling = NullValueHandling.Ignore)]
        public string When { get; set; }

        [JsonProperty("style",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Style> Style { get; set; }

        [JsonProperty("paddingLeft", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> PaddingLeft { get; set; }

        [JsonProperty("paddingTop", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> PaddingTop { get; set; }

        [JsonProperty("paddingRight", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> PaddingRight { get; set; }

        [JsonProperty("paddingBottom", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> PaddingBottom { get; set; }

        [JsonProperty("minWidth", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> MinWidth { get; set; }

        [JsonProperty("minHeight", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> MinHeight { get; set; }

        [JsonProperty("maxWidth", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> MaxWidth { get; set; }

        [JsonProperty("maxHeight", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> MaxHeight { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> Height { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> Width { get; set; }

        [JsonProperty("alignSelf",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> AlignSelf { get; set; }

        [JsonProperty("bottom",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<AbsoluteDimension> Bottom { get; set; }

        [JsonProperty("grow",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Grow { get; set; }

        [JsonProperty("left",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<AbsoluteDimension> Left { get; set; }

        [JsonProperty("numbering",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Numbering { get; set; }

        [JsonProperty("position",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Position { get; set; }

        [JsonProperty("right",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<AbsoluteDimension> Right { get; set; }

        [JsonProperty("shrink",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Shrink { get; set; }

        [JsonProperty("spacing",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> Spacing { get; set; }

        [JsonProperty("top",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<AbsoluteDimension> Top { get; set; }
    }
}