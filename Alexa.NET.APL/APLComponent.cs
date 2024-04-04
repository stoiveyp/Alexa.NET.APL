using System.Collections.Generic;
using Alexa.NET.APL;
using Alexa.NET.APL.Components;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    [JsonConverter(typeof(APLComponentConverter))]
    public abstract class APLComponent:APLComponentBase
    {
        [JsonProperty("inheritParentState", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> InheritParentState { get; set; }

        [JsonProperty("style",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Style { get; set; }

        [JsonProperty("padding", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(GenericSingleOrListConverter<int>))]
        public APLValue<IList<int>> Padding { get; set; }

        [JsonProperty("paddingStart", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue PaddingStart { get; set; }

        [JsonProperty("paddingEnd", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue PaddingEnd { get; set; }

        [JsonProperty("paddingLeft", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue PaddingLeft { get; set; }

        [JsonProperty("paddingTop", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue PaddingTop { get; set; }

        [JsonProperty("paddingRight", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue PaddingRight { get; set; }

        [JsonProperty("paddingBottom", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue PaddingBottom { get; set; }

        [JsonProperty("minWidth", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue MinWidth { get; set; }

        [JsonProperty("minHeight", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue MinHeight { get; set; }

        [JsonProperty("maxWidth", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue MaxWidth { get; set; }

        [JsonProperty("maxHeight", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue MaxHeight { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue Height { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue Width { get; set; }

        [JsonProperty("alignSelf",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> AlignSelf { get; set; }

        [JsonProperty("bottom",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue Bottom { get; set; }

        [JsonProperty("grow",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> Grow { get; set; }

        [JsonProperty("left",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue Left { get; set; }

        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue Start { get; set; }

        [JsonProperty("numbering",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Numbering { get; set; }

        [JsonProperty("position",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Position { get; set; }

        [JsonProperty("right",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue Right { get; set; }

        [JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue End { get; set; }

        [JsonProperty("shrink",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Shrink { get; set; }

        [JsonProperty("spacing",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue Spacing { get; set; }

        [JsonProperty("top",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue Top { get; set; }

        [JsonProperty("speech",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Speech { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> Properties { get; set; }

        [JsonProperty("accessibilityLabel",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> AccessibilityLabel { get; set; }

        [JsonProperty("checked",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> Checked { get; set; }

        [JsonProperty("disabled",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> Disabled { get; set; }

        [JsonProperty("display",NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(APLValueEnumConverter<APLDisplay>))]
        public APLValue<APLDisplay> Display { get; set; }

        [JsonProperty("onMount", NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnMount { get; set; }

        [JsonProperty("onCursorEnter", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnCursorEnter { get; set; }

        [JsonProperty("onCursorExit", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnCursorExit { get; set; }

        [JsonProperty("onSpeechMark", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnSpeechMark { get; set; }

        [JsonProperty("transform",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLTransform>> Transform { get; set; }

        [JsonProperty("shadowColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ShadowColor { get; set; }

        [JsonProperty("shadowHorizontalOffset", NullValueHandling = NullValueHandling.Ignore)]
        public APLAbsoluteDimensionValue ShadowHorizontalOffset { get; set; }

        [JsonProperty("shadowVerticalOffset", NullValueHandling = NullValueHandling.Ignore)]
        public APLAbsoluteDimensionValue ShadowVerticalOffset { get; set; }

        [JsonProperty("shadowRadius",NullValueHandling = NullValueHandling.Ignore)]
        public APLAbsoluteDimensionValue ShadowRadius { get; set; }

        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> Opacity { get; set; }

        [JsonProperty("entities", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(GenericSingleOrListConverter<object>))]
        public APLValue<IList<object>> Entities { get; set; }

        [JsonProperty("handleTick",NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(GenericSingleOrListConverter<TickHandler>))]
        public APLValue<IList<TickHandler>> HandleTick { get; set; }

        [JsonProperty("handleVisibilityChange", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(GenericSingleOrListConverter<VisibilityChangeHandler>))]
        public APLValue<IList<VisibilityChangeHandler>> HandleVisibilityChange { get; set; }

        [JsonProperty("role",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Role { get; set; }

        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(GenericSingleOrListConverter<APLAction>))]
        public APLValue<IList<APLAction>> Actions { get; set; }

        [JsonProperty("preserve", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<string>> Preserve { get; set; }

        [JsonProperty("layoutDirection", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<LayoutDirection>))]
        public APLValue<LayoutDirection?> LayoutDirection { get; set; }
    }
}