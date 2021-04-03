using System.Runtime.Serialization;

namespace Alexa.NET.APL
{
    public enum DrawOrder
    {
        [EnumMember(Value="nextAbove")]
        NextAbove,
        [EnumMember(Value = "nextBelow")]
        NextBelow,
        [EnumMember(Value = "higherAbove")]
        HigherAbove,
        [EnumMember(Value = "higherBelow")]
        HigherBelow
    }
}