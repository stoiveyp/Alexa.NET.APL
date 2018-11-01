using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class TouchWrapper:APLComponent
    {
        public override string Type => nameof(TouchWrapper);

        [JsonProperty("disabled",NullValueHandling = NullValueHandling.Ignore)]
        public bool Boolean { get; set; }

        [JsonProperty("item",NullValueHandling = NullValueHandling.Ignore)]
        public IList<APLComponent> Item { get; set; }

        [JsonProperty("onPress",NullValueHandling = NullValueHandling.Ignore)]
        public APLCommand OnPress { get; set; }
    }
}
