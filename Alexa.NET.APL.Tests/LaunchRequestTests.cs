using System;
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
    }
}
