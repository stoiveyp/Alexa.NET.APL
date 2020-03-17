using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class GradientTest
    {
        [Fact]
        public void LinearGradient()
        {
            var expectedRaw = @"{
            ""type"": ""linear"",
            ""colorRange"": [
            ""white"",
            ""transparent""
                ],
            ""inputRange"": 0.5
        }";

            var expected = JObject.Parse(expectedRaw);

            var gradient = new APLGradient
            {
                Type = APLGradientType.Linear,
                ColorRange = new[] {"white", "transparent"},
                InputRange = 0.5
            };

            Assert.True(JObject.DeepEquals(expected,JToken.FromObject(gradient)));
        }
    }
}
