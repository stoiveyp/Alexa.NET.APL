using System.Collections.Generic;
using System.Runtime.Versioning;
using Alexa.NET.APL;
using Alexa.NET.APL.Commands;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.APL.VectorGraphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.Response.APL
{
    public class APLDocument: APLDocumentBase
    {
        public override string Type => "APL";

        public APLDocument()
        {
            
        }

        public APLDocument(APLDocumentVersion version) : base(version)
        {

        }

        [JsonProperty("handleKeyDown", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLKeyboardHandlerConverter))]
        public APLValue<IList<APLKeyboardHandler>> HandleKeyDown { get; set; }

        [JsonProperty("handleKeyUp", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLKeyboardHandlerConverter))]
        public APLValue<IList<APLKeyboardHandler>> HandleKeyUp { get; set; }

        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(StringEnumConverter))]
        public ViewportTheme? Theme { get; set; }

        [JsonProperty("import", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Import> Imports { get; set; }

        [JsonProperty("styles", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Style> Styles { get; set; }

        [JsonProperty("graphics",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,AVG> Graphics { get; set; }

        [JsonProperty("commands",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, CommandDefinition> Commands { get; set; }

        [JsonProperty("export",NullValueHandling = NullValueHandling.Ignore)]
        public ExportList Export { get; set; }

        [JsonProperty("background",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<DocumentBackgroundColor> Background { get; set; }
    }
}