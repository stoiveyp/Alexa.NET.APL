using System.Runtime.Serialization;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    [JsonConverter(typeof(UnknownDocumentVersionConverter))]
    public enum APLDocumentVersion
    {
        Unknown,
        [EnumMember(Value = "1.0")]
        V1,
        [EnumMember(Value = "1.1")]
        V1_1,
        [EnumMember(Value = "1.2")]
        V1_2,
        [EnumMember(Value = "1.3")]
        V1_3,
        [EnumMember(Value = "1.4")]
        V1_4
    }
}