using System.Runtime.Serialization;

namespace Alexa.NET.APL.Audio
{
    public enum SelectorStrategy
    {
        [EnumMember(Value="normal")]
        Normal,
        [EnumMember(Value="randomItem")]
        RandomItem,
        [EnumMember(Value="randomData")]
        RandomData,
        [EnumMember(Value="randomItemRandomData")]
        RandomItemRandomData
    }
}