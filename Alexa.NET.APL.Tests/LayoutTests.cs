using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.APL.Layouts;
using Alexa.NET.Response;
using Alexa.NET.Response.APL;
using Newtonsoft.Json.Linq;
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

        [Fact]
        public void AlexaFooterAddsImport()
        {
            var document = new APLDocument();
            AlexaFooter.ImportInto(document);
            document.MainTemplate = new Layout(new AlexaFooter("Hint Text"));
            Assert.Contains(Import.AlexaLayouts,document.Imports);
        }

        [Fact]
        public void AlexaFooterRecognisesExistingImport()
        {
            var document = new APLDocument {Imports = new List<Import> {Import.AlexaLayouts}};
            AlexaFooter.ImportInto(document);
            Assert.Single(document.Imports);
        }

        [Fact]
        public void AlexaFooterGeneratesCorrectJson()
        {
            var footer = new AlexaFooter("Hint Text");
            Assert.True(Utility.CompareJson(footer,"AlexaFooter.json"));
        }

        [Fact]
        public void AlexaHeaderGeneratesCorrectJson()
        {
            var header = new AlexaHeader
            {
                HeaderTitle = "Header Title",
                HeaderSubtitle = "Header Subtitle",
                HeaderAttributionImage = "http://HeaderAttributionImage",
                HeaderBackgroundColor = "red",
                HeaderBackButton = true,
                HeaderNavigationAction = "Go Back"
            };



            Assert.True(Utility.CompareJson(header,"AlexaHeader.json"));
        }
    }
}
