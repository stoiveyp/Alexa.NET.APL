using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaPageCounter:APLComponent
    {
        [JsonProperty("type")] public override string Type => nameof(AlexaPageCounter);

        [JsonProperty("currentPageComponentId",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> CurrentPageComponentId { get; set; }

        [JsonProperty("currentPage",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> CurrentPage { get; set; }

        [JsonProperty("theme",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }

        [JsonProperty("totalPages",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> TotalPages { get; set; }

    }
}
