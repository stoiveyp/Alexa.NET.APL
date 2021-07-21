using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Alexa.NET.APL.Components
{
    public enum LayoutDirection
    {
        [EnumMember(Value="inherit")]
        Inherit,
        [EnumMember(Value="LTR")]
        LTR,
        [EnumMember(Value = "RTL")]
        RTL
    }
}
