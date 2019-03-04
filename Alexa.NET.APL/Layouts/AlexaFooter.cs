using System.Collections.Generic;
using Alexa.NET.APL.Components;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Layouts
{
    public class AlexaFooter:CustomComponent
    {
        public static void ImportInto(APLDocument document)
        {
            Import.AlexaLayouts.ImportInto(document);
        }

        public AlexaFooter():base(nameof(AlexaFooter)) { }

        public AlexaFooter(string hintText) : this()
        {
            HintText = hintText;
        }

        [JsonProperty("hintText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HintText { get; set; }
    }
}
