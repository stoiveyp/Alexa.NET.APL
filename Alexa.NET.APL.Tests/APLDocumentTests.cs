using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.APL.Components;
using Alexa.NET.APL.DataSources;
using Alexa.NET.Response;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class APLDocumentTests
    {
        [Fact]
        public void TopLevelProperties()
        {
            var doc = GetDocument();
            Assert.Equal("APL", doc.Type);
            Assert.Equal("1.0", doc.Version);
            Assert.NotNull(doc.MainTemplate);
        }

        [Fact]
        public void Resources()
        {
            var resources = Utility.ExampleFileContent<Resource[]>("Resource.json");
            Assert.Equal(2, resources.Length);

            var first = resources.First();
            Assert.Equal(2, first.Dimensions.Count);
            Assert.Equal("myFontSize", first.Dimensions.First().Key);
            Assert.Equal("28dp", first.Dimensions.First().Value);

            var second = resources.Skip(1).First();
            Assert.Equal(When.RoundViewport, second.When);
            Assert.Equal(2, second.Resources.Count);
        }

        [Fact]
        public void Styles()
        {
            var styles = Utility.ExampleFileContent<Dictionary<string, Style>>("Styles.json");
            Assert.Equal(2, styles.Count);

            var first = styles["baseText"];
            var second = styles["title"];

            Assert.Equal(2, first.Values.Count);
            Assert.Equal("Amazon Ember Display", first.Values[0].Properties["fontFamily"]);
            Assert.Equal("${state.focused}", first.Values[1].When);
            Assert.Equal("blue", first.Values[1].Properties["color"]);

            Assert.Equal("baseText", second.Extends.First());
            Assert.Single(second.Values);
        }

        [Fact]
        public void Imports()
        {
            var importText = "{\r\n        \"name\": \"alexa-styles\",\r\n        \"version\" : \"1.0.0\"\r\n    }";
            var import = new Import("alexa-styles", "1.0.0");
            Assert.True(JToken.DeepEquals(JObject.Parse(importText), JObject.FromObject(import)));
        }

        [Fact]
        public void LongTextExample()
        {
            var result = Utility.ExampleFileContent<APLDocument>("LongText.json");
            Assert.Single(result.MainTemplate.Parameters);
            Assert.Equal("payload", result.MainTemplate.Parameters.First().Name);
            Assert.Equal("100", result.Styles["textStyleBase0"].Value.Properties["fontWeight"]);
        }

        [Fact]
        public void KeeferExample()
        {
            var result = Utility.ExampleFileContent<RenderDocumentDirective>("KeeferCustom.json");
            var document = result.Document;
            Assert.Equal(10, document.Styles.Count);
            Assert.Equal(2, document.Styles["textStylePrimary"].Extends.Count);
            Assert.Equal(2, document.MainTemplate.Items.Count);
            Assert.Equal(3, ((Container)document.MainTemplate.Items[1]).Items.Value.Count);
            Assert.Single(result.DataSources);
            var dataSource = Assert.IsType<ObjectDataSource>(result.DataSources["bodyTemplate7Data"]);
            Assert.True(dataSource.TopLevelData.ContainsKey("backgroundImage"));
            Assert.IsType<JObject>(dataSource.TopLevelData["backgroundImage"]);
        }

        private APLDocument GetDocument()
        {
            return Utility.ExampleFileContent<RenderDocumentDirective>("RenderDocument.json").Document;
        }
    }
}
