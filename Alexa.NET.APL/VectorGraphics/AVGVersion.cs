using System.Runtime.Serialization;

namespace Alexa.NET.APL.VectorGraphics
{
    public enum AVGVersion
    {
        Unknown,
        [EnumMember(Value="1.0")]
        V1_0,
        [EnumMember(Value="1.1")]
        V1_1
    }
}