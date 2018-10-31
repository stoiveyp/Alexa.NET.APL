using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;

namespace Alexa.NET.APL.Components
{
    public class Text:APLComponent
    {
        public const string ComponentType = "Text";
        public Text() { }

        public Text(string text) { }
        public override string Type => ComponentType;
    }
}
