using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.APL
{
    public class UserEventRequest: Request.Type.Request
    {
        public const string RequestType = "Alexa.Presentation.APL.UserEvent";

        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("arguments", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,object> Arguments { get; set; }

        [JsonProperty("source",NullValueHandling = NullValueHandling.Ignore)]
        public APLCommandSource Source { get; set; }

        [JsonProperty("components",NullValueHandling = NullValueHandling.Ignore)]
        public string[] Components { get; set; }
    }
}
