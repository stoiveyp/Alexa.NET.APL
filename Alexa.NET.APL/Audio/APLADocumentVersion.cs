using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Alexa.NET.APL.Audio
{
    public enum APLADocumentVersion
    {
        Unknown,
        [EnumMember(Value="0.8")]
        V0_8,
        [EnumMember(Value = "0.9")]
        V0_9
    }
}
