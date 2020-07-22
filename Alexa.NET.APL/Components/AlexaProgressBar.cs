using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaProgressBar:APLComponent
    { 
        public override string Type => nameof(AlexaProgressBar);

        [JsonProperty("bufferValue",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> BufferValue { get; set; }


    }
}
