using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Alexa.NET.APL.Components
{
    public enum Scale
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "fill")]
        Fill,
        [EnumMember(Value = "best-fill")]
        BestFill,
        [EnumMember(Value = "best-fit")]
        BestFit,
        [EnumMember(Value = "best-fit-down")]
        BestFitDown
    }
}
