using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class Image:APLComponent
    {
        public const string ComponentType = "Image";
        public override string Type => ComponentType;

        [JsonProperty("align",NullValueHandling = NullValueHandling.Ignore)]
        public string Align { get; set; }

        [JsonProperty("borderRadius",NullValueHandling = NullValueHandling.Ignore)]
        public string BorderRadius { get; set; }

        [JsonProperty("height",NullValueHandling = NullValueHandling.Ignore)]
        public int Height { get; set; }

        [JsonProperty("opacity",NullValueHandling = NullValueHandling.Ignore)]
        public double Opacity { get; set; }

        [JsonProperty("overlayColor",NullValueHandling = NullValueHandling.Ignore)]
        public string OverlayColor { get; set; }

        [JsonProperty("scale",NullValueHandling = NullValueHandling.Ignore)]
        public string Scale { get; set; }

        [JsonProperty("source",NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        [JsonProperty("width",NullValueHandling = NullValueHandling.Ignore)]
        public int Width { get; set; }
    }
}
