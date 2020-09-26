using System.Runtime.Serialization;

namespace Alexa.NET.APL.Extensions.SmartMotion
{
    public enum WakeWordResponse
    {
        [EnumMember(Value="doNotMoveOnWakeWord")]
        DoNotMoveOnWakeWord,
        [EnumMember(Value="followOnWakeWord")]
        FollowOnWakeWord,
        [EnumMember(Value="turnToWakeWord")]
        TurnToWakeWord
    }
}