using System.Runtime.Serialization;

namespace Alexa.NET.APL.Commands
{
    public enum SetPagePosition
    {
        [EnumMember(Value="absolute")]
        Absolute,
        [EnumMember(Value="relative")]
        Relative
    }
}