using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response;
using Alexa.NET.Response.APL;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class RenderDocumentDirectiveTests
    {
        [Fact]
        public void TopLevelPropertyMatches()
        {
            var directive = Utility.ExampleFileContent<RenderDocumentDirective>("RenderDocumentDirective.json");
            Assert.Equal("Alexa.Presentation.APL.RenderDocument",directive.Type);
            Assert.Equal("anydocument",directive.Token);
            Assert.IsType<APLDocument>(directive.Document);

            Assert.NotNull(directive.Document);
            Assert.NotNull(directive.DataSources);

            Assert.True(directive.DataSources.ContainsKey("templateData"));
        }
    }
}
