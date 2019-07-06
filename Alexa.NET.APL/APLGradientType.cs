using System.Runtime.Serialization;

namespace Alexa.NET.APL
{
    public enum APLGradientType
    {
        [EnumMember(Value="linear")]
        Linear,
        [EnumMember(Value = "radial")]
        Radial
    }
}