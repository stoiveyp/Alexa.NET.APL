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

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("arguments")]
        public Dictionary<string,object> Arguments { get; set; }


    }
}
