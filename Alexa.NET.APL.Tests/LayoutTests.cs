using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.Response;
using Alexa.NET.Response.APL;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class LayoutTests
    {
        [Fact]
        public void TopLevelProperties()
        {
            var layout = Utility.ExampleFileContent<Layout>("layout.json");
            Assert.Equal("A basic header with a title and a logo", layout.Description);
            Assert.Equal(2,layout.Parameters.Count);
            Assert.Equal(2,layout.Items.Count);
        }

        [Fact]
        public void ParameterProperties()
        {
            var layout = Utility.ExampleFileContent<Layout>("layout.json");
            var first = layout.Parameters.First();
            Assert.Equal("title",first.Name);
            Assert.Equal(ParameterType.@string,first.Type);
        }
    }
}
