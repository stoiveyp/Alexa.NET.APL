using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class EditText:ActionableComponent
    {
        public override string Type => nameof(EditText);

        [JsonProperty("borderColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> BorderColor { get; set; }

        [JsonProperty("borderStrokeWidth",NullValueHandling = NullValueHandling.Ignore)]
        public APLAbsoluteDimensionValue BorderStrokeWidth { get; set; }

        [JsonProperty("borderWidth",NullValueHandling = NullValueHandling.Ignore)]
        public APLAbsoluteDimensionValue BorderWidth { get; set; }

        [JsonProperty("color",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Color { get; set; }

        [JsonProperty("fontFamily",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FontFamily { get; set; }

        [JsonProperty("fontSize",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> FontSize { get; set; }

        [JsonProperty("fontStyle",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FontStyle { get; set; }

        [JsonProperty("fontWeight",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FontWeight { get; set; }

        [JsonProperty("highlightColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HighlightColor { get; set; }

        [JsonProperty("hint",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Hint { get; set; }

        [JsonProperty("hintColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HintColor { get; set; }

        [JsonProperty("hintStyle",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HintStyle { get; set; }

        [JsonProperty("hintWeight",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HintWeight { get; set; }

        [JsonProperty("keyboardType",NullValueHandling = NullValueHandling.Ignore),
            JsonConverter(typeof(APLValueEnumConverter<KeyboardType>))]
        public APLValue<KeyboardType?> KeyboardType { get; set; }

        [JsonProperty("maxLength",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int> MaxLength { get; set; }

        [JsonProperty("onTextChange",NullValueHandling = NullValueHandling.Ignore),
            JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnTextChange { get; set; }

        [JsonProperty("onSubmit", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnSubmit { get; set; }

        [JsonProperty("secureInput",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> SecureInput { get; set; }

        [JsonProperty("selectOnFocus",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> SelectOnFocus { get; set; }

        [JsonProperty("size",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Size { get; set; }

        [JsonProperty("submitKeyType", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<SubmitKeyType>))]
        public APLValue<SubmitKeyType?> SubmitKeyType { get; set; }

        [JsonProperty("text",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Text { get; set; }

        [JsonProperty("validCharacters",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ValidCharacters { get; set; }
    }
}
