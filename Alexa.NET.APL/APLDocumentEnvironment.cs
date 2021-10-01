using System.Collections.Generic;
using Alexa.NET.APL;
using Alexa.NET.APL.Components;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    public class APLDocumentEnvironment
    {
        [JsonProperty("lang",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Lang { get; set; }

        [JsonProperty("layoutDirection", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<LayoutDirection>))]
        public APLValue<LayoutDirection?> LayoutDirection { get; set; }

        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(ParameterListConverter), true)]
        public IList<Parameter> Parameters { get; set; }
    }
}