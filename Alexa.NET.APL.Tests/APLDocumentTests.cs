using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response;
using Alexa.NET.Response.APL;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class APLDocumentTests
    {
        [Fact]
        public void TopLevelProperties()
        {
            var doc = GetDocument();
            Assert.Equal("APL",doc.Type);
            Assert.Equal("1.0",doc.Version);
            Assert.NotNull(doc.MainTemplate);
        }

        private APLDocument GetDocument()
        {
            return Utility.ExampleFileContent<RenderDocumentDirective>("RenderDocumentDirective.json").Document;
        }
    }
}
