using System.Runtime.Serialization;

namespace Alexa.NET.APL.Components
{
    public enum TimeTextDirection
    {
        [EnumMember(Value="none")]
        None,
        [EnumMember(Value = "up")]
        Up,
        [EnumMember(Value = "down")]
        Down,
    }
}