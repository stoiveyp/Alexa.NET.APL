using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class IdleCommand:APLCommand
    {
        public const string CommandType = "Idle";
        public override string Type => CommandType;
    }
}
