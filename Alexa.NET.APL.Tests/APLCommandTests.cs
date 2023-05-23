using System.Collections.Generic;
using System.Linq;
using Alexa.NET.APL.Commands;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class APLCommandTests
    {

        [Fact]
        public void CommandDefinitionWorksProperly()
        {
            var commandDefinition = Utility.ExampleFileContent<CommandDefinition>("jackinthebox.json");
            Assert.Equal(2,commandDefinition.Parameters.Value.Count);
            var item = Assert.IsType<AnimateItem>(commandDefinition.Commands.Value.First());
            var transform = Assert.IsType<AnimatedTransform>(item.Value.Value.Skip(1).First());
            Assert.Equal(2,transform.From.Value.Count);
            Assert.Equal(0.1,transform.From.Value.First().ScaleX.Value);
        }

        [Fact]
        public void AnimatedItemWorksProperly()
        {
            var list = new List<AnimatedProperty>
            {
                new AnimatedOpacity
                {
                    From = 0,
                    To = 1
                }
            };

            var command = new AnimateItem
            {
                Duration = 1000,
                RepeatCount = 9,
                RepeatMode = RepeatMode.Reverse,
                Value = list
            };

            Assert.True(Utility.CompareJson(command,"AnimatedItem.json"));

            var deserial = Utility.ExampleFileContent<AnimateItem>("AnimatedItem.json");
            var property = Assert.Single(deserial.Value.Value);
            var opacity = Assert.IsType<AnimatedOpacity>(property);
            Assert.Equal(0,opacity.From.Value);
            Assert.Equal(1,opacity.To.Value);
        }

        [Fact]
        public void SpeakItemWorksProperly()
        {
            var command = new SpeakItem
            {
                HighlightMode = HighlightMode.Line,
                Align = ItemAlignment.Center,
                ComponentId = "myJokeSetup"
            };

            var parsed = Utility.ExampleFileContent<SpeakItem>("SpeakItem.json");
            Assert.NotNull(parsed);
            Assert.True(Utility.CompareJson(command, "SpeakItem.json"));
        }

        [Fact]
        public void PlayMediaWorksCorrectly()
        {
            var command = new ControlMedia
            {
                Command = ControlMediaCommand.Seek,
                ComponentId = "myAudioPlayer",
                Value = 5000
            };
            Assert.True(Utility.CompareJson(command,"ControlMediaCommand.json"));
        }

        [Fact]
        public void SetValueWorksCorrectly()
        {
            var command = new SetValue
            {
                ComponentId = "jokePunchline",
                Property = "opacity",
                Value = "1"
            };
            Assert.True(Utility.CompareJson(command,"SetValueCommand.json"));
        }

        [Fact]
        public void PlayMediaDeserializesCorrectly()
        {
            var command = Utility.ExampleFileContent<ControlMedia>("ControlMediaCommand.json");
            Assert.Equal(ControlMediaCommand.Seek,command.Command.Value);
            Assert.Equal("myAudioPlayer",command.ComponentId.Value);
            Assert.Equal(5000,command.Value.Value);
        }

        [Fact]
        public void Finish()
        {
            var command = new Finish();
            var jo = JObject.FromObject(command);
            Assert.Single(jo);
            Assert.Equal("Finish",jo["type"].Value<string>());
            Assert.IsType<Finish>(JsonConvert.DeserializeObject<APLCommand>(jo.ToString()));
        }

        [Fact]
        public void Reinflate()
        {
            var command = new Reinflate{PreservedSequencers = new[] {"test"}};
            var jo = JObject.FromObject(command);
            Assert.Equal(2,jo.Count);
            Assert.Equal("Reinflate", jo["type"].Value<string>());
            Assert.Equal(JTokenType.Array, jo["preservedSequencers"].Type);
            var sequencer = Assert.Single(jo["preservedSequencers"]);
            Assert.Equal("test", sequencer.Value<string>());
            Assert.IsType<Reinflate>(JsonConvert.DeserializeObject<APLCommand>(jo.ToString()));
        }

        [Fact]
        public void Select()
        {
            var select = Utility.ExampleFileContent<Select>("Select.json");
            Assert.Single(select.Commands.Value);
            Assert.Equal(5, select.Data.Length);
        }
    }
}
