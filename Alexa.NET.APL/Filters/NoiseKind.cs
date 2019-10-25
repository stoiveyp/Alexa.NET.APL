using System.Runtime.Serialization;

namespace Alexa.NET.APL.Filters
{
    public enum NoiseKind
    {
        [EnumMember(Value="gaussian")]
        Gaussian,
        [EnumMember(Value="uniform")]
        Uniform
    }
}