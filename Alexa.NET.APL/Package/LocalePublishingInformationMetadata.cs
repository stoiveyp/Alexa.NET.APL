using Newtonsoft.Json;

namespace Alexa.NET.APL.Package;

public class LocalePublishingInformationMetadata
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("keywords")]
    public string[] Keywords { get; set; }

    [JsonProperty("iconUri")]
    public string IconUri { get; set; }

    [JsonProperty("previews")]
    public string[] Previews { get; set; }
}