using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class OpenURL:APLCommand
    {
        [JsonProperty("type")] public override string Type => nameof(OpenURL);

        [JsonProperty("onFail",NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnFail { get; set; }
    }
}
