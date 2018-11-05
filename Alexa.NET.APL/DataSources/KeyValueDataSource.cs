using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.APL.DataSources
{
    public class KeyValueDataSource:APLDataSource
    {
        [JsonProperty("type",NullValueHandling = NullValueHandling.Ignore)]
        public override string Type { get; }

        [JsonExtensionData]
        public Dictionary<string,object> Properties { get; set; }
    }
}
