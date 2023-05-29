using System.Runtime.Serialization;

namespace Alexa.NET.APL.Package;

public enum InstallStateChanges
{
    [EnumMember(Value="AUTOMATIC")]
    Automatic,
    [EnumMember(Value="INFORM")]
    Inform
}