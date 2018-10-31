using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.APL
{
    public class APLTransformer
    {
        [JsonProperty("inputPath")]
        public string InputPath { get; set; }

        [JsonProperty("outputName")]
        public string OutputName { get; set; }

        [JsonProperty("transformer")]
        public string Transformer { get; set; }
    }
}
