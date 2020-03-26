using System.Runtime.Serialization;

namespace Alexa.NET.APL.Components
{
    public enum RatingSlotMode
    {
        [EnumMember(Value="single")]
        Single,
        [EnumMember(Value = "multiple")]
        Multiple
    }
}