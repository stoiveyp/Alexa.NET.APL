using System.Runtime.Serialization;

namespace Alexa.NET.APL.Components
{
    public enum KeyboardType
    {
        [EnumMember(Value="decimalPad")]
        DecimalPad,
        [EnumMember(Value="emailAddress")]
        EmailAddress,
        [EnumMember(Value="normal")]
        Normal,
        [EnumMember(Value="numberPad")]
        NumberPad,
        [EnumMember(Value="phonePad")]
        PhonePad,
        [EnumMember(Value="url")]
        Url
    }
}