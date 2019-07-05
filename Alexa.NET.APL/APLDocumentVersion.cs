using System.Runtime.Serialization;

namespace Alexa.NET.Response.APL
{
    public enum APLDocumentVersion
    {
        [EnumMember(Value = "1.0")]
        V1,
        [EnumMember(Value = "1.1")]
        V1_1
    }
}