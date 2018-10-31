using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL;
using Alexa.NET.Request;
using Newtonsoft.Json;

namespace Alexa.NET.Request
{
    public class APLSkillRequest:SkillRequest
    {
        [JsonProperty("context")]
        public new APLContext Context { get; set; }
    }
}
