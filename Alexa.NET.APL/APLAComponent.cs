using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    [JsonConverter(typeof(APLAComponentConverter))]
    public abstract class APLAComponent:APLComponentBase
    {

    }
}