﻿using System.Collections.Generic;
using System.Linq;
using Alexa.NET.APL;
using Alexa.NET.APL.Audio;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.Response.APL
{
    public abstract class APLComponentBase
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public abstract string Type { get; }

        [JsonProperty("bind", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Binding> Bindings { get; set; }

        public bool ShouldSerializeBindings()
        {
            return Bindings?.Any() ?? false;
        }

        [JsonProperty("when", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> When { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Description { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public AudioDuration? Duration { get; set; }
    }
}