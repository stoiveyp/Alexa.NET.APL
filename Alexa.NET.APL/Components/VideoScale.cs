using System.Runtime.Serialization;

namespace Alexa.NET.APL.Components
{
    public enum VideoScale
    {
        [EnumMember(Value="best-fill")]
        BestFill,
        [EnumMember(Value="best-fit")]
        BestFit
    }
}
