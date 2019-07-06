using System.Runtime.Serialization;

namespace Alexa.NET.APL.Commands
{
    public enum HighlightMode
    {
        [EnumMember(Value="line")]
        Line,
        [EnumMember(Value = "block")]
        Block
    }
}