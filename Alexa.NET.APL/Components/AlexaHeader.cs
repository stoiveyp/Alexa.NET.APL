using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.Components;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaHeader:APLComponent
    {
        public AlexaHeader()
        {
        }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public override string Type => nameof(AlexaHeader);

        [JsonProperty("headerTitle", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HeaderTitle { get; set; }

        [JsonProperty("headerSubtitle",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HeaderSubtitle { get; set; }

        [JsonProperty("headerAttributionText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HeaderAttributionText { get; set; }

        [JsonProperty("headerAttributionImage",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HeaderAttributionImage { get; set; }

        [JsonProperty("headerAttributionPrimacy",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool> HeaderAttributionPrimacy { get; set; }

        [JsonProperty("headerBackButton",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool> HeaderBackButton { get; set; }

        [JsonProperty("headerBackButtonAccessibilityLabel",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HeaderBackButtonAccessibilityLabel { get; set; }

        [JsonProperty("headerBackButtonCommand",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLCommand>> HeaderBackButtonCommand { get; set; }

        [JsonProperty("headerBackgroundColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HeaderBackgroundColor { get; set; }

        [JsonProperty("headerDivider",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool> HeaderDivider { get; set; }

        [JsonProperty("theme",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }

    }
}
