using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.APL.Commands;
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
        [Theory]
        [InlineData("1.0", APLDocumentVersion.V1)]
        [InlineData("1.1", APLDocumentVersion.V1_1)]
        [InlineData("1.2", APLDocumentVersion.V1_2)]
        [InlineData("1.3", APLDocumentVersion.V1_3)]
        [InlineData("1.4", APLDocumentVersion.V1_4)]
        [InlineData("1.5", APLDocumentVersion.V1_5)]
        [InlineData("1.6", APLDocumentVersion.V1_6)]
        [InlineData("1.7", APLDocumentVersion.V1_7)]
        [InlineData("1.8", APLDocumentVersion.V1_8)]
        [InlineData("1.9", APLDocumentVersion.V1_9)]
        [InlineData("2022.1", APLDocumentVersion.V2022_1)]
        [InlineData("2022.2", APLDocumentVersion.V2022_2)]
        [InlineData("2023.1", APLDocumentVersion.V2023_1)]
        [InlineData("2023.2", APLDocumentVersion.V2023_2)]
        public void TopLevelProperties(string versionString, APLDocumentVersion version)
        {
            var doc = GetDocument(version);
            Assert.Equal("APL", doc.Type);
            Assert.Equal(version, doc.Version);
            Assert.Equal(versionString, doc.VersionString);
            Assert.NotNull(doc.MainTemplate);
        }

        [Fact]
        public void HandleInvalidDocumentVersion()
        {
            var doc = GetDocument();
            var jobject = JObject.FromObject(doc);
            jobject["version"] = "1.21";
            var newDoc = JsonConvert.DeserializeObject<APLDocument>(jobject.ToString());
            Assert.Equal(APLDocumentVersion.Unknown,newDoc.Version);
        }

        [Fact]
        public void HandleValidDocumentVersion()
        {
            var doc = GetDocument(APLDocumentVersion.V1_2);
            var jobject = JObject.FromObject(doc);
            var newDoc = JsonConvert.DeserializeObject<APLDocument>(jobject.ToString());
            Assert.Equal(APLDocumentVersion.V1_2, newDoc.Version);
        }


        [Fact]
        public void DailyCheese()
        {
            var doc = Utility.ExampleFileContent<APLDocument>("Example_DailyCheese.json");
            Assert.Equal("APL", doc.Type);
            Assert.Equal(APLDocumentVersion.V1_3, doc.Version);
            Assert.NotNull(doc.MainTemplate);
            Assert.Equal(1,doc.OnMount.Value.Count);

            var mount = doc.OnMount.Value.Single();
            Assert.IsType<OpenURL>(mount);
            Assert.True(Utility.CompareJson(doc, "Example_DailyCheese.json"));
        }

        [Fact]
        public void ChangeDocumentLayout()
        {
            var doc = Utility.ExampleFileContent<APLDocument>("Example_ChangeDocumentLayout.json");
            Assert.Equal("APL", doc.Type);
            Assert.Equal(APLDocumentVersion.V1_6, doc.Version);
            Assert.True(doc.Settings.SupportsResizing);

            var occ = doc.OnConfigChange.Value.Single();
            Assert.IsType<Reinflate>(occ);
            Assert.True(Utility.CompareJson(doc, "Example_ChangeDocumentLayout.json"));
        }

        [Fact]
        public void Resources()
        {
            var resources = Utility.ExampleFileContent<Resource[]>("Resource.json");
            Assert.Equal(2, resources.Length);

            var first = resources.First();
            Assert.Equal(2, first.Dimensions.Count);
            Assert.Equal("myFontSize", first.Dimensions.First().Key);
            Assert.Equal("28dp", first.Dimensions.First().Value.GetValue());

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
            var document = result.Document as APLDocument;
            Assert.Equal(APLDocumentVersion.V1_1, document.Version);
            Assert.Equal(10, document.Styles.Count);
            Assert.Equal(2, document.Styles["textStylePrimary"].Extends.Count);
            Assert.Equal(2, document.MainTemplate.Items.Count);
            Assert.Equal(3, ((Container)document.MainTemplate.Items[1]).Items.Value.Count);
            Assert.Single(result.DataSources);
            var dataSource = Assert.IsType<ObjectDataSource>(result.DataSources["bodyTemplate7Data"]);
            Assert.True(dataSource.TopLevelData.ContainsKey("backgroundImage"));
            Assert.IsType<JObject>(dataSource.TopLevelData["backgroundImage"]);
        }

        [Fact]
        public void ListDataSource()
        {
            var list = new ListDataSource {ListId = "lt1Sample", TotalNumberOfItems = 10};
            list.ListPage.ListItems.Add(new TestListItem("gouda",1));
            list.ListPage.ListItems.Add(new TestListItem("cheddar",2));
            list.ListPage.ListItems.Add(new TestListItem("blue",3));
            list.ListPage.ListItems.Add(new TestListItem("brie",4));
            list.ListPage.ListItems.Add(new TestListItem("cheddar",5));
            list.ListPage.ListItems.Add(new TestListItem("parm",6));
            Assert.True(Utility.CompareJson(list, "ListDataSource.json"));
        }

        [Fact]
        public void DynamicIndexList()
        {
            var list = new DynamicIndexList("my-list-id", 0) {MinimumInclusiveIndex = 0, MaximumExclusiveIndex = 200};
            list.Items.Add(new DynamicListItem { PrimaryText = "item 1"});
            list.Items.Add(new DynamicListItem { PrimaryText = "item 2"});
            list.Items.Add(new DynamicListItem { PrimaryText = "item 3"});
            list.Items.Add(new DynamicListItem { PrimaryText = "item 4"});
            list.Items.Add(new DynamicListItem { PrimaryText = "item 5"});
            list.Items.Add(new DynamicListItem { PrimaryText = "item 6"});
            list.Items.Add(new DynamicListItem { PrimaryText = "item 7"});
            list.Items.Add(new DynamicListItem { PrimaryText = "item 8"});
            list.Items.Add(new DynamicListItem { PrimaryText = "item 9"});
            list.Items.Add(new DynamicListItem { PrimaryText = "item 10"});
            Assert.True(Utility.CompareJson(list, "DynamicSourceExample.json"));
            var source = Utility.ExampleFileContent<APLDataSource>("DynamicSourceExample.json");
            Assert.IsType<DynamicIndexList>(source);
        }

        [Fact]
        public void DynamicTokenList()
        {
            var source = "DataSource_DynamicTokenList.json";
            Utility.AssertSerialization<APLDataSource, DynamicTokenList>(source);
        }

        [Fact]
        public void RenderDocumentLink()
        {
            
            Utility.AssertSerialization<RenderDocumentDirective>("RenderDocumentLink.json");
        }

        private APLDocument GetDocument(APLDocumentVersion? version = null)
        {
            var doc = Utility.ExampleFileContent<RenderDocumentDirective>("RenderDocument.json").Document as APLDocument;
            if (version.HasValue)
            {
                doc.Version = version.Value;
            }

            return doc;
        }
    }

    internal class DynamicListItem
    {
        [JsonProperty("primaryText")]
        public string PrimaryText { get; set; }
    }

    public class TestListItem
    {
        [JsonProperty("listItemIdentifier")]
        public string ListItemIdentifier { get; }

        [JsonProperty("token")]
        public string Token { get; }

        [JsonProperty("ordinalNumber")]
        public int Ordinal { get; }

        public TestListItem(string identifier, int ordinal)
        {
            ListItemIdentifier = identifier;
            Token = identifier;
            Ordinal = ordinal;
        }
    }
}
