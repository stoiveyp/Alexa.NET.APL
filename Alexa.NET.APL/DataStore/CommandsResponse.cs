using Newtonsoft.Json;

namespace Alexa.NET.APL.DataStore;

public class CommandsResponse
{
    [JsonProperty("results")]
    public CommandResult[] Results { get; set; }

    [JsonProperty("queuedResultId")]
    public string QueuedResultId { get; set; }
}