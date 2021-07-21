using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.APL.Components;
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
            var layout = Utility.ExampleFileContent<Layout>("Layout.json");
            Assert.Equal("A basic header with a title and a logo", layout.Description);
            Assert.Equal(2,layout.Parameters.Count);
            Assert.Equal(2,layout.Items.Count);
        }

        [Fact]
        public void ParameterProperties()
        {
            var layout = Utility.ExampleFileContent<Layout>("Layout.json");
            var first = layout.Parameters.First();
            Assert.Equal("title",first.Name);
            Assert.Equal(ParameterType.@string,first.Type);
        }

        [Fact]
        public void AlexaImageSerialisesCorrectly()
        {
            var image = new AlexaImage
            {
                ImageSource= "https://d2o906d8ln7ui1.cloudfront.net/images/MollyforBT7.png",
                ImageRoundedCorner = true,
                Scale = Scale.BestFit,
                ImageAlignment = AlexaImageAlignment.Center,
                ImageWidth = new AbsoluteDimension(75,"vh"),
                ImageAspectRatio = AlexaImageAspectRatio.Square,
                ImageBlurredBackground = true
            };

            Assert.True(Utility.CompareJson(image, "AlexaImage.json"));
        }

        [Fact]
        public void AlexaFooterAddsImport()
        {
            var document = new APLDocument();
            Import.AlexaLayouts.Into(document);
            document.MainTemplate = new Layout(
                new AlexaFooter("Hint Text")
            ).AsMain();
            Assert.Contains(Import.AlexaLayouts,document.Imports);
        }

        [Fact]
        public void AlexaFooterRecognisesExistingImport()
        {
            var document = new APLDocument {Imports = new List<Import> {Import.AlexaLayouts}};
            Import.AlexaLayouts.Into(document);
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
                HeaderTitle = "Header title",
                HeaderSubtitle = "Header subtitle",
                HeaderAttributionImage = "https://d2o906d8ln7ui1.cloudfront.net/images/cheeseskillicon.png",
                HeaderBackgroundColor = "red",
                HeaderBackButton = true,
                HeaderBackButtonAccessibilityLabel = "back",
                HeaderAttributionText = "Attribution",
                HeaderAttributionPrimacy = true,
                HeaderDivider = true,
                LayoutDirection = LayoutDirection.RTL
            };

            Assert.True(Utility.CompareJson(header,"AlexaHeader.json"));
        }
    }
}
