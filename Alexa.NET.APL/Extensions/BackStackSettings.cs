using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Extensions
{
    public class BackStackSettings
    {
        [JsonProperty("backstackId", NullValueHandling = NullValueHandling.Ignore)]
        public string BackstackId { get; set; }
    }
}
