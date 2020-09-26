using System;
using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.APL.Extensions.SmartMotion
{
    public class SmartMotionExtension:APLExtension
    {
        public const string URL = "alexaext:smartmotion:10";

        public SmartMotionExtension()
        {
            Uri = URL;
        }

        public SmartMotionExtension(string name) : this()
        {
            Name = name;
        }
    }
}
