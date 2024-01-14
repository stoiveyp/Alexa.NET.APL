using System.Runtime.Serialization;

namespace Alexa.NET.Response.APL;

public enum ImportType
{
    [EnumMember(Value="package")]
    Package,
    [EnumMember(Value = "oneOf")]
    OneOf,
    [EnumMember(Value = "allOf")]
    AllOf,
}