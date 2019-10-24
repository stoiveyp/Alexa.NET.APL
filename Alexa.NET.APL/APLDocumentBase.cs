using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL
{
    [JsonConverter(typeof(APLDocumentConverter))]
    public abstract class APLDocumentBase
    {
        protected APLDocumentBase()
        {
            Version = APLDocumentVersion.V1;
        }

        protected APLDocumentBase(APLDocumentVersion version)
        {
            Version = version;
        }

        [JsonProperty("type")] public abstract string Type { get; }

        [JsonProperty("version"), JsonConverter(typeof(StringEnumConverter))]
        public APLDocumentVersion Version { get; set; }

        [JsonProperty("layouts", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Layout> Layouts { get; set; }

        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Resource> Resources { get; set; }

        [JsonProperty("mainTemplate")]
        public Layout MainTemplate { get; set; }

        [JsonProperty("onMount", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter), true)]
        public APLValue<IList<APLCommand>> OnMount { get; set; }

        [JsonProperty("settings", NullValueHandling = NullValueHandling.Ignore)]
        public APLDocumentSettings Settings { get; set; }
    }
}
