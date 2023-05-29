using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL.Package;

public class LocalePublishingInformation
{
    [JsonProperty("targetViewport")]
    [JsonConverter(typeof(StringEnumConverter))]
    public TargetViewport TargetViewport { get; set; }

    [JsonProperty("metadata")]
    public LocalePublishingInformationMetadata Metadata { get; set; }
}