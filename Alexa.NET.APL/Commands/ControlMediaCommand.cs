using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Alexa.NET.APL.Commands
{
    public enum ControlMediaCommand
    {
        [EnumMember(Value="play")]
        Play,
        [EnumMember(Value = "pause")]
        Pause,
        [EnumMember(Value = "next")]
        Next,
        [EnumMember(Value = "previous")]
        Previous,
        [EnumMember(Value = "rewind")]
        Rewind,
        [EnumMember(Value = "seek")]
        Seek,
        [EnumMember(Value = "setTrack")]
        SetTrack
    }
}
