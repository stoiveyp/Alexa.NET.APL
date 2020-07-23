using System.Runtime.Serialization;

namespace Alexa.NET.APL.Gestures
{
    public enum SwipeAction
    {
        [EnumMember(Value="reveal")]
        Reveal,
        [EnumMember(Value="slide")]
        Slide,
        [EnumMember(Value="cover")]
        Cover
    }
}