using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    [JsonConverter(typeof(APLDataSourceConverter))]
    public interface IAPLDataSource
    {

    }
}