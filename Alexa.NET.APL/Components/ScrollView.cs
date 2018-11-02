using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class ScrollView:APLComponent
    {
        public const string ComponentType = "ScrollView";
        public override string Type => ComponentType;

        [JsonProperty("item",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<APLComponent>> Item { get; set; }
    }
}
