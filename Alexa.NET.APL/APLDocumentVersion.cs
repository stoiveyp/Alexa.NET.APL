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
        V1_4,
        [EnumMember(Value = "1.5")]
        V1_5,
        [EnumMember(Value = "1.6")]
        V1_6,
        [EnumMember(Value = "1.7")]
        V1_7,
        [EnumMember(Value = "1.8")]
        V1_8,
        [EnumMember(Value = "1.9")]
        V1_9,
        [EnumMember(Value = "2022.1")]
        V2022_1
    }
}