using System.Runtime.Serialization;

namespace Alexa.NET.APL.Components
{
    public enum MetadataPosition
    {
        [EnumMember(Value="above_right")]
        AboveRight,
        [EnumMember(Value="above_left_right")]
        AboveLeftRight,
        [EnumMember(Value="below_left_right")]
        BelowLeftRight
    }
}