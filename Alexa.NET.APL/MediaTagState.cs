using System.Runtime.Serialization;

namespace Alexa.NET.APL
{
    public enum MediaTagState
    {
        [EnumMember(Value="idle")]
        Idle,
        [EnumMember(Value="paused")]
        Paused,
        [EnumMember(Value="playing")]
        Playing
    }
}