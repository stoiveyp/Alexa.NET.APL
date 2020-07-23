using System.Runtime.Serialization;

namespace Alexa.NET.APL.Components
{
    public enum ProgressBarType
    {
        [EnumMember(Value="determinate")]
        Determinate,
        [EnumMember(Value="indeterminate")]
        Indeterminate
    }
}