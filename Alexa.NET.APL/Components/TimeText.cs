using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class TimeText:TextBase
    {
        public override string Type => nameof(TimeText);

        [JsonProperty("direction",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<TimeTextDirection>))]
        public APLValue<TimeTextDirection?> Direction { get; set; }

        [JsonProperty("format",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Format { get; set; }

        [JsonProperty("start",NullValueHandling = NullValueHandling.Ignore)]
        public new APLValue<int?> Start { get; set; }
    }
}
