using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.Response;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
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

        [Fact]
        public void Resources()
        {
            var resources = Utility.ExampleFileContent<Resource[]>("Resource.json");
            Assert.Equal(2,resources.Length);

            var first = resources.First();
            Assert.Equal(2,first.Dimensions.Count);
            Assert.Equal("myFontSize",first.Dimensions.First().Key);
            Assert.Equal("28dp",first.Dimensions.First().Value);

            var second = resources.Skip(1).First();
            Assert.Equal(When.RoundViewport,second.When);
            Assert.Equal(2,second.Resources.Count);
        }

        [Fact]
        public void Styles()
        {
            var styles = Utility.ExampleFileContent<Dictionary<string, Style>>("Styles.json");
            Assert.Equal(2,styles.Count);

            var first = styles["baseText"];
            var second = styles["title"];

            Assert.Equal(2, first.Values.Count);
            Assert.Equal("Amazon Ember Display",first.Values[0].Properties["fontFamily"]);
            Assert.Equal("${state.focused}",first.Values[1].When);
            Assert.Equal("blue",first.Values[1].Properties["color"]);

            Assert.Equal("baseText", second.Extends);
            Assert.Single(second.Values);
        }

        private APLDocument GetDocument()
        {
            return Utility.ExampleFileContent<RenderDocumentDirective>("RenderDocument.json").Document;
        }
    }
}
