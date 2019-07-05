using System.Runtime.Serialization;

namespace Alexa.NET.APL.Commands
{
    public enum SetStateStates
    {
        [EnumMember(Value = "checked")]
        Checked,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "focused")]
        Focused,
        [EnumMember(Value = "karaoke")]
        Karaoke,
        [EnumMember(Value = "karaokeTarget")]
        KaraokeTarget,
        [EnumMember(Value = "pressed")]
        Pressed
    }
}