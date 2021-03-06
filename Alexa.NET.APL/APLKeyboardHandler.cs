﻿using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class APLKeyboardHandler
    {
        [JsonProperty("when", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> When { get; set; }

        [JsonProperty("propagate", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> Propagate { get; set; }

        [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> Commands { get; set; }

        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Description { get; set; }
    }
}
