using System.Runtime.Serialization;

namespace Alexa.NET.APL.Components
{
    public enum ScrollDirection
    {
        [EnumMember(Value="horizontal")]
        Horizontal,
        [EnumMember(Value="vertical")]
        Vertical
    }
}