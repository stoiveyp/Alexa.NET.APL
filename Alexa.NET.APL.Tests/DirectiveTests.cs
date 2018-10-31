using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.Commands;
using Alexa.NET.Response;
using Alexa.NET.Response.APL;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class DirectiveTests
    {
        [Fact]
        public void RenderDocument()
        {
            var directive = Utility.ExampleFileContent<RenderDocumentDirective>("RenderDocument.json");
            Assert.Equal("Alexa.Presentation.APL.RenderDocument",directive.Type);
            Assert.Equal("anydocument",directive.Token);
            Assert.IsType<APLDocument>(directive.Document);

            Assert.NotNull(directive.Document);
            Assert.NotNull(directive.DataSources);

            Assert.True(directive.DataSources.ContainsKey("templateData"));
        }

        [Fact]
        public void ExecuteCommands()
        {
            var directive = new ExecuteCommandsDirective("[SkillProvidedToken]");
            directive.Commands = new List<APLCommand>();
            directive.Commands.Add(new IdleCommand());

            Assert.True(Utility.CompareJson(directive, "ExecuteCommands.json"));
        }
    }
}
