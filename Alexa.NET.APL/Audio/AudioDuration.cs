using System.Runtime.Serialization;

namespace Alexa.NET.APL.Audio
{
    public enum AudioDuration
    {
        [EnumMember(Value="auto")]
        Auto,
        [EnumMember(Value="trimToParent")]
        TrimToParent
    }
}