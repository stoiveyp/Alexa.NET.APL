using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Alexa.NET.APL.Commands;
using Alexa.NET.APL.JsonConverter;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class CommandTests
    {

        [Fact]
        public void AnimatedItemWorksProperly()
        {
            var list = new List<AnimatedProperty>
            {
                new AnimatedProperty
                {
                    Property = "opacity",
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
        public void SetStateWorksCorrectly()
        {
            var command = new SetState
            {
                ComponentId = "myButton",
                State = SetStateStates.Checked,
                Value = true
            };
            Assert.True(Utility.CompareJson(command, "SetSTateCommand.json"));
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
    }
}
