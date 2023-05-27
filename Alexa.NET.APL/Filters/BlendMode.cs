using System.Runtime.Serialization;

namespace Alexa.NET.APL.Filters
{
    public enum BlendMode
    {
        [EnumMember(Value = "normal")] Normal,
        [EnumMember(Value = "multiply")] Multiply,
        [EnumMember(Value = "screen")] Screen,
        [EnumMember(Value = "overlay")] Overlay,
        [EnumMember(Value = "darken")] Darken,
        [EnumMember(Value = "lighten")] Lighten,
        [EnumMember(Value = "color-dodge")] ColorDodge,
        [EnumMember(Value = "color-burn")] ColorBurn,
        [EnumMember(Value = "hard-light")] HardLight,
        [EnumMember(Value = "soft-light")] SoftLight,
        [EnumMember(Value = "difference")] Difference,
        [EnumMember(Value = "exclusion")] Exclusion,
        [EnumMember(Value = "hue")] Hue,
        [EnumMember(Value = "saturation")] Saturation,
        [EnumMember(Value = "color")] Color,
        [EnumMember(Value = "luminosity")] Luminosity,
        [EnumMember(Value = "source-atop")] SourceAtop,
        [EnumMember(Value = "source-in")] SourceIn,
        [EnumMember(Value = "source-out")] SourceOut
    }
}