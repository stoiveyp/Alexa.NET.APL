using System.Runtime.Serialization;

namespace Alexa.NET.APL.Components
{
    public enum Snap
    {
        [EnumMember(Value="none")]
        None,
        [EnumMember(Value="start")]
        Start,
        [EnumMember(Value="center")]
        Center,
        [EnumMember(Value="end")]
        End,
        [EnumMember(Value="forceStart")]
        ForceStart,
        [EnumMember(Value="forceCenter")]
        ForceCenter,
        [EnumMember(Value="forceEnd")]
        ForceEnd
    }
}