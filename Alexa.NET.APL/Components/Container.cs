using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.APL.Components
{
    public class Container:APLComponent
    {
        [JsonProperty("type")]
        public override string Type => nameof(Container);
        
        [JsonProperty("alignItems",NullValueHandling = NullValueHandling.Ignore)]
        public string AlignItems { get; set; }

        [JsonProperty("data",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,object> Data { get; set; }

        [JsonProperty("direction",NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        [JsonProperty("firstItem",NullValueHandling = NullValueHandling.Ignore)]
        public IList<APLComponent> FirstItem { get; set; }

        [JsonProperty("lastItem",NullValueHandling = NullValueHandling.Ignore)]
        public IList<APLComponent> LastItem { get; set; }

        [JsonProperty("items",NullValueHandling = NullValueHandling.Ignore)]
        public IList<APLComponent> Items { get; set; }

        [JsonProperty("justifyContent",NullValueHandling = NullValueHandling.Ignore)]
        public string JustifyContent { get; set; }

        [JsonProperty("numbered",NullValueHandling = NullValueHandling.Ignore)]
        public bool? Numbered { get; set; }


    }
}
