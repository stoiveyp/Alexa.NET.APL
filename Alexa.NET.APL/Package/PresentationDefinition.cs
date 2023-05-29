using Newtonsoft.Json;

namespace Alexa.NET.APL.Package;

public class PresentationDefinition
{
    [JsonProperty("type")] public string Type { get; set; } = "APL_PRESENTATION";

    [JsonProperty("documentUrl")]
    public string DocumentUrl { get; set; }

    [JsonProperty("datasourceUrl")]
    public string DatasourceUrl { get; set; }
}