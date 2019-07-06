using System.Runtime.Serialization;

namespace Alexa.NET.Response.APL
{
    public enum APLDisplay
    {
        [EnumMember(Value="none")]
        None,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "invisible")]
        Invisible
    }
}