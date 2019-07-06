using System.Runtime.Serialization;

namespace Alexa.NET.APL.VectorGraphics
{
    public enum AVGScaleType
    {
        [EnumMember(Value="none")]
        None,
        [EnumMember(Value = "grow")]
        Grow,
        [EnumMember(Value = "shrink")]
        Shrink,
        [EnumMember(Value = "stretch")]
        Stretch
    }
}