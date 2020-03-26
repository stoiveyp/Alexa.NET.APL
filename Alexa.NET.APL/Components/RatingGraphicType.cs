using System.Runtime.Serialization;

namespace Alexa.NET.APL.Components
{
    public enum RatingGraphicType
    {
        [EnumMember(Value="AVG")]
        AVG,
        [EnumMember(Value="image")]
        Image
    }
}