﻿using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public abstract class APLDocumentBase:APLDocumentReference
    {
        protected APLDocumentBase()
        {
            Version = APLDocumentVersion.V1;
        }

        protected APLDocumentBase(APLDocumentVersion version)
        {
            Version = version;
        }

        [JsonIgnore]
        public APLDocumentVersion Version
        {
            get => EnumParser.ToEnum(VersionString, APLDocumentVersion.Unknown);
            set => VersionString = EnumParser.ToEnumString(typeof(APLDocumentVersion), value);
        }

        [JsonProperty("version")]
        public string VersionString { get; set; }

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

        [JsonProperty("extensions",NullValueHandling = NullValueHandling.Ignore),
            JsonConverter(typeof(GenericSingleOrListConverter<APLExtension>))]
        public APLValue<IList<APLExtension>> Extensions { get; set; }
    }
}
