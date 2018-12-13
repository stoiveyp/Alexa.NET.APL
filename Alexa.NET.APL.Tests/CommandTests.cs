using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Alexa.NET.APL.Commands;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class CommandTests
    {
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
        public void PlayMediaDeserializesCorrectly()
        {
            var command = Utility.ExampleFileContent<ControlMedia>("ControlMediaCommand.json");
            Assert.Equal(ControlMediaCommand.Seek,command.Command.Value);
            Assert.Equal("myAudioPlayer",command.ComponentId.Value);
            Assert.Equal(5000,command.Value.Value);
        }
    }
}
