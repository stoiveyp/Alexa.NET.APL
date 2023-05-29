﻿using Alexa.NET.APL.Package;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class APLPackageTests
    {
        [Fact]
        public void ValidPackageDocument()
        {
            Utility.AssertSerialization<APLPackage>("APLPackage.json");
        }

        [Fact]
        public void ValidPresentationDefinition()
        {
            Utility.AssertSerialization<PresentationDefinition>("PresentationDefinition.json");
        }
    }
}
