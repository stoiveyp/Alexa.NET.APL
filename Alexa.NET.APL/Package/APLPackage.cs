using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL.Package
{
    public class APLPackage
    {
        [JsonProperty("packageVersion")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PackageVersion PackageVersion { get; set; }

        [JsonProperty("packageType")] public string PackageType { get; } = "APL_PACKAGE";

        [JsonProperty("publishingInformation",NullValueHandling = NullValueHandling.Ignore)]
        public PublishingInformation PublishingInformation { get; set; }

        [JsonProperty("manifest")]
        public Manifest Manifest { get; set; }
    }
}
