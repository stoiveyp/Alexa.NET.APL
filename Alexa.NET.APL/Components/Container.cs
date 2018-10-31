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
        public override string Type => "Container";

    }
}
