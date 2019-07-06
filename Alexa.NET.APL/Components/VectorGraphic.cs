using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class VectorGraphic:APLComponent
    {
        [JsonProperty("type")]
        public override string Type => nameof(VectorGraphic);

        [JsonProperty("align",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Align { get; set; }

        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Scale> Scale { get; set; }

        [JsonProperty("source",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Source { get; set; }


    }
}
