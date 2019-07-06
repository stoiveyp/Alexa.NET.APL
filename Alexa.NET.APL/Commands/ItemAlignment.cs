using System.Runtime.Serialization;

namespace Alexa.NET.APL.Commands
{
    public enum ItemAlignment
    {
        [EnumMember(Value="first")]
        First,
        [EnumMember(Value = "center")]
        Center,
        [EnumMember(Value = "last")]
        Last,
        [EnumMember(Value = "visible")]
        Visible
    }
}