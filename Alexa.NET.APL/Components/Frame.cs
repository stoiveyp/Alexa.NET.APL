using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class Frame:APLComponent
    {
        public const string ComponentType = "Frame";

        public override string Type => ComponentType;

        [JsonProperty("backgroundColor",NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundColor { get; set; }

        [JsonProperty("borderBottomLeftRadius",NullValueHandling = NullValueHandling.Ignore)]
        public string BorderBottomLeftRadius { get; set; }

        [JsonProperty("borderBottomRightRadius",NullValueHandling = NullValueHandling.Ignore)]
        public string BorderBottomRightRadius { get; set; }

        [JsonProperty("borderColor",NullValueHandling = NullValueHandling.Ignore)]
        public string BorderColor { get; set; }

        [JsonProperty("borderRadius",NullValueHandling = NullValueHandling.Ignore)]
        public string BorderRadius { get; set; }

        [JsonProperty("borderTopLeftRadius",NullValueHandling = NullValueHandling.Ignore)]
        public string BorderTopLeftRadius { get; set; }

        [JsonProperty("borderTopRightRadius",NullValueHandling = NullValueHandling.Ignore)]
        public string BorderTopRightRadius { get; set; }

        [JsonProperty("borderWidth",NullValueHandling = NullValueHandling.Ignore)]
        public string BorderWidth { get; set; }

        [JsonProperty("item",NullValueHandling = NullValueHandling.Ignore)]
        public IList<APLComponent> Item { get; set; }
    }
}
