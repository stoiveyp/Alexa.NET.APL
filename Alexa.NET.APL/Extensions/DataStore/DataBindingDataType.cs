using System.Runtime.Serialization;

namespace Alexa.NET.APL.Extensions.DataStore;

public enum DataBindingDataType
{
    [EnumMember(Value="OBJECT")]
    Object,
    [EnumMember(Value="ARRAY")]
    Array
}