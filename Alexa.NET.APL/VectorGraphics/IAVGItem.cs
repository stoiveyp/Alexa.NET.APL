using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.VectorGraphics
{
    [JsonConverter(typeof(AVGItemConverter))]
    public interface IAVGItem
    {
        string Type { get; }
    }
}