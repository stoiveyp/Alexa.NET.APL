using Newtonsoft.Json;

namespace Alexa.NET.APL.DataStore;

public class QueuedResultResponse
{
    [JsonProperty("items")]
    public CommandResult[] Items { get; set; }

    [JsonProperty("paginationContext",NullValueHandling = NullValueHandling.Ignore)]
    public PaginationContext PaginationContext { get; set; }
}