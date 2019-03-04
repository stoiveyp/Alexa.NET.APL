using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.Components;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Layouts
{
    public class AlexaHeader:CustomComponent
    {
        public static void ImportInto(APLDocument document)
        {
            Import.AlexaLayouts.ImportInto(document);
        }

        public AlexaHeader() : base(nameof(AlexaHeader))
        {
        }

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

        [JsonProperty("headerNavigationAction",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HeaderNavigationAction { get; set; }

        [JsonProperty("headerBackgroundColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HeaderBackgroundColor { get; set; }

    }
}
