using Newtonsoft.Json;

namespace Alexa.NET.APL.Package;

public class PresentationDefinitionFile
{
    [JsonProperty("url")]
    public string Url { get; set; }
}