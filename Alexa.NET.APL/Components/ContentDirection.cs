using System.Runtime.Serialization;

namespace Alexa.NET.APL.Components
{
    public enum ContentDirection
    {
        [EnumMember(Value="column")]
        Column,
        [EnumMember(Value="row")]
        Row
    }
}