using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL.Extensions.DataStore;

public class DataBinding
{
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("dataBindingName")]
    public string DataBindingName { get; set; }

    [JsonProperty("dataType")]
    [JsonConverter(typeof(StringEnumConverter))]
    public DataBindingDataType DataType { get; set; }

    [JsonProperty("startIndex",NullValueHandling = NullValueHandling.Ignore)]
    public int? StartIndex { get; set; }

    [JsonProperty("endIndex",NullValueHandling = NullValueHandling.Ignore)]
    public int? EndIndex { get; set; }
}