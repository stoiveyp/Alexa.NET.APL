using System.Collections.Generic;
using System.Linq;
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
    public class DirectiveTests
    {
        [Fact]
        public void RenderDocument()
        {
            var directive = Utility.ExampleFileContent<RenderDocumentDirective>("RenderDocument.json");
            Assert.Equal("Alexa.Presentation.APL.RenderDocument",directive.Type);
            Assert.Equal("anydocument",directive.Token);
            var doc = Assert.IsType<APLDocument>(directive.Document);

            Assert.NotNull(directive.Document);
            Assert.Single(directive.DataSources);
            Assert.NotNull(doc.Export.Resources);
            Assert.Equal(2,doc.Export.Resources.Length);

            Assert.True(directive.DataSources.ContainsKey("templateData"));
        }

        [Fact]
        public void DeserializeComplexRenderDocument()
        {
            var directive = Utility.ExampleFileContent<RenderDocumentDirective>("InputDirectiveTest.json");
            Assert.NotNull(directive);

            var source = Assert.IsType<ObjectDataSource>(directive.DataSources["StreamPlayerData"]);
            Assert.Equal("textToHint",source.Transformers.First().Transformer);

            var wrapper = Assert.IsType<TouchWrapper>(directive.Document.Layouts["TouchableBox"].Items.First());
            var container = ((Container) wrapper.Item.Value.First()).Items.Value.Skip(1).First() as Container;
            Assert.NotNull(((Container)container.Items.Value.First()).Items);
        }
        
        [Fact]
        public void DataSource()
        {
            var objectDS = Utility.ExampleFileContent<ObjectDataSource>("ObjectDataSource.json");
            var transformer = Assert.Single(objectDS.Transformers);

            Assert.Equal("catFactSsml",transformer.InputPath);
            Assert.Equal("catFactSpeech",transformer.OutputName);
            Assert.Equal("ssmlToSpeech",transformer.Transformer);

            var random =
                JsonConvert.DeserializeObject<APLDataSource>(new JObject(new JProperty("test", "random")).ToString());
            Assert.IsType<KeyValueDataSource>(random);
            Assert.Single(((KeyValueDataSource)random).Properties);
        }

        [Fact]
        public void ExecuteCommands()
        {
            var directive = new ExecuteCommandsDirective("[SkillProvidedToken]");
            directive.Commands = new List<APLCommand>();
            directive.Commands.Add(new Idle());

            Assert.True(Utility.CompareJson(directive, "ExecuteCommands.json"));
        }

        [Fact]
        public void SendIndexListData()
        {
            SendIndexListDataDirective.AddSupport();
            var dir = Utility.ExampleFileContent<IDirective>("SendIndexListDataDirective.json");
            Assert.IsType<SendIndexListDataDirective>(dir);

            var directive = new SendIndexListDataDirective
            {
                Token = "developer-provided-token",
                CorrelationToken = "alexa-provided-correlation-token",
                ListId = "my-list-id",
                ListVersion = 3,
                StartIndex = 11,
                MinimumInclusiveIndex = 11,
                MaximumExclusiveIndex = 21,
                Items = new List<object>
                {
                    new DynamicListItem{PrimaryText = "item 11"},
                    new DynamicListItem{PrimaryText = "item 12"},
                    new DynamicListItem{PrimaryText = "item 13"},
                    new DynamicListItem{PrimaryText = "item 14"},
                    new DynamicListItem{PrimaryText = "item 15"},
                    new DynamicListItem{PrimaryText = "item 16"},
                    new DynamicListItem{PrimaryText = "item 17"},
                    new DynamicListItem{PrimaryText = "item 18"},
                    new DynamicListItem{PrimaryText = "item 19"},
                    new DynamicListItem{PrimaryText = "item 20"},
                }
            };
            Assert.True(Utility.CompareJson(directive, "SendIndexListDataDirective.json"));
        }
    }
}