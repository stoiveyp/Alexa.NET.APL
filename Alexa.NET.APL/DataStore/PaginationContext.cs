using Newtonsoft.Json;

namespace Alexa.NET.APL.DataStore;

public class PaginationContext
{
    [JsonProperty("totalCount")]
    public int TotalCount { get; set; }

    [JsonProperty("nextToken",NullValueHandling = NullValueHandling.Ignore)]
    public string NextToken { get; set; }

    [JsonProperty("previousToken",NullValueHandling = NullValueHandling.Ignore)]
    public string PreviousToken { get; set; }
}