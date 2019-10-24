using System;
using System.Linq;
using Alexa.NET.Request;
using Alexa.NET.Response.APL;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class LaunchRequestTests
    {
        [Fact]
        public void AbleToConfirmInterfaceName()
        {
            var request = Utility.ExampleFileContent<SkillRequest>("LaunchRequest.json");
            Assert.True(request.Context.System.Device.SupportedInterfaces.ContainsKey(APLInterface.InterfaceName));

            var result = request.Context.System.Device.SupportedInterfaces[APLInterface.InterfaceName];
            Assert.NotNull(result);
        }

        [Fact]
        public void SupportsHelperMethodConfirms()
        {
            var request = Utility.ExampleFileContent<SkillRequest>("LaunchRequest.json");
            APLInterface.Supported(request);
        }

        [Fact]
        public void APLInterfaceDetailsReturnsVersion()
        {
            var request = Utility.ExampleFileContent<SkillRequest>("LaunchRequest.json");
            Assert.Equal(APLDocumentVersion.V1_1,request.APLInterfaceDetails().Runtime.MaxVersion);
        }

        [Fact]
        public void MainViewportDeserializesCorrectly()
        {
            var request = Utility.ExampleFileContent<APLSkillRequest>("LaunchRequest.json");
            Assert.Equal(ViewportShape.Rectangle, request.Context.Viewport.Shape);
            Assert.Equal(160, request.Context.Viewport.DPI);
        }

        [Fact]
        public void ViewportArrayTypeDeserializesCorrectly()
        {
            var request = Utility.ExampleFileContent<APLSkillRequest>("LaunchRequest.json");
            Assert.Equal(2,request.Context.Viewports.Length);
            Assert.Single(request.Context.Viewports.OfType<APLViewport>());
            Assert.Single(request.Context.Viewports.OfType<APLTViewport>());
        }

        [Fact]
        public void APLViewportPropertiesSetCorrectly()
        {
            var request = Utility.ExampleFileContent<APLSkillRequest>("LaunchRequest.json");
            var viewport = request.Context.Viewports.OfType<APLViewport>().First();
            Assert.Equal(ViewportShape.Rectangle,viewport.Shape);
            Assert.Equal(160, viewport.DPI);
            Assert.Equal("STANDARD", viewport.PresentationType);
            Assert.False(viewport.CanRotate);

            Assert.NotNull(viewport.Configuration.Current);
            var config = viewport.Configuration.Current;
            Assert.NotNull(config.Video);
            Assert.Equal(2,config.Video.Codecs.Length);

            Assert.Equal("DISCRETE",config.Size.Type);
            Assert.Equal(1024, config.Size.PixelWidth);
            Assert.Equal(600, config.Size.PixelHeight);
        }

        [Fact]
        public void APLTViewportPropertiesSetCorrectly()
        {
            var request = Utility.ExampleFileContent<APLSkillRequest>("LaunchRequest.json");
            var viewport = request.Context.Viewports.OfType<APLTViewport>().First();
            
            var profile = Assert.Single(viewport.SupportedProfiles);
            Assert.Equal(APLTProfile.FourCharacterClock,profile);
            Assert.Equal(4,viewport.LineLength);
            Assert.Equal(1,viewport.LineCount);
            Assert.Equal(APLTFormat.SevenSegment,viewport.Format);
            var segment = Assert.Single(viewport.InterSegments);
            Assert.Equal(2,segment.X);
            Assert.Equal(0,segment.Y);
            Assert.Equal(3,segment.Characters.Length);


        }
    }
}
