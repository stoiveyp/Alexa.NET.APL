using System.Runtime.Serialization;

namespace Alexa.NET.APL.Audio
{
    public enum SpeechContentType
    {
        [EnumMember(Value="PlainText")]
        PlainText,
        [EnumMember(Value="SSML")]
        Ssml
    }
}