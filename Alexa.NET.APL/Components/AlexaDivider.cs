using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaDivider:APLComponent
    {
        [JsonProperty("type")]
        public override string Type => nameof(AlexaDivider);

        [JsonProperty("theme",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }
    }
}
