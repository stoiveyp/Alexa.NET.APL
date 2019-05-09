using System.Security.Cryptography.X509Certificates;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Filters
{
    [JsonConverter(typeof(ImageFilterConverter))]
    public interface IImageFilter
    {
        [JsonProperty("type")]
        string Type { get; }
    }
}
