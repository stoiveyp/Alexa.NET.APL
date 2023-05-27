using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL.DataStore;

public class CommandsTarget
{
    [JsonProperty("type")]
    [JsonConverter(typeof(StringEnumConverter))]
    public TargetType Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("items")]
    public List<string> Items { get; set; }

    public bool ShouldSerializeItems() => Type == TargetType.Devices;
    public bool ShouldSerializeId() => Type == TargetType.User;

}