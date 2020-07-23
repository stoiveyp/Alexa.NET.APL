using System.Runtime.Serialization;

namespace Alexa.NET.APL.Components
{
    public enum SliderType
    {
        [EnumMember(Value="default")]
        Default,
        [EnumMember(Value="icon")]
        Icon,
        [EnumMember(Value="text")]
        Text
    }
}