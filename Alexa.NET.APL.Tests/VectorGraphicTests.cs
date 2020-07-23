using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.VectorGraphics;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class VectorGraphicTests
    {
        [Fact]
        public void AVGGeneratesCorrectJson()
        {
            Utility.AssertSerialization<AVG>("AVG.json");
        }
    }
}
