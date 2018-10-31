using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;

namespace Alexa.NET.APL.Components
{
    public class Text:APLComponent
    {
        public Text() { }

        public Text(string text) { }
        public override string Type => "Text";
    }
}
