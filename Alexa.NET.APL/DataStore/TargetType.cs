using System.Runtime.Serialization;

namespace Alexa.NET.APL.DataStore;

public enum TargetType
{
    [EnumMember(Value="DEVICES")]
    Devices,
    [EnumMember(Value="USER")]
    User
}