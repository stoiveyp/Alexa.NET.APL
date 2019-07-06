using System.Collections.Generic;
using Alexa.NET.APL;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.APL.VectorGraphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.Response.APL
{
    public class APLDocument
    {
        public APLDocument()
        {
            Version = APLDocumentVersion.V1;
        }

        public APLDocument(APLDocumentVersion version)
        {
            Version = version;
        }

        [JsonProperty("type")]
        public string Type => "APL";

        [JsonProperty("version"), JsonConverter(typeof(StringEnumConverter))]
        public APLDocumentVersion Version { get; set; }

        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(StringEnumConverter))]
        public ViewportTheme Theme { get; set; }

        [JsonProperty("mainTemplate")]
        public Layout MainTemplate { get; set; }

        [JsonProperty("import", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Import> Imports { get; set; }

        [JsonProperty("layouts", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Layout> Layouts { get; set; }

        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Resource> Resources { get; set; }

        [JsonProperty("styles", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Style> Styles { get; set; }

        [JsonProperty("graphics",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,AVG> Graphics { get; set; }

        [JsonProperty("onMount",NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnMount { get; set; }

        [JsonProperty("command",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,APLCommand> Commands { get; set; }

        [JsonProperty("settings",NullValueHandling = NullValueHandling.Ignore)]
        public APLDocumentSettings Settings { get; set; }
    }
}