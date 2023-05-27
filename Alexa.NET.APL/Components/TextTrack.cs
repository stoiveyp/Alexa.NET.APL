using System;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components;

public class TextTrack
{
    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Type { get; } = "caption";

    [JsonProperty("url")]
    public APLValue<Uri> Uri { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Description { get; set; }
}