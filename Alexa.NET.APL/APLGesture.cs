using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    [JsonConverter(typeof(APLGestureConverter))]
    public abstract class APLGesture
    {
        [JsonProperty("type")]
        public abstract string Type { get; }
    }
}
