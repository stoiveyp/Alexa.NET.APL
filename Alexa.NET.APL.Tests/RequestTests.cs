using Alexa.NET.Request;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class RequestTests
    {
        [Fact]
        public void LoadIndexListData()
        {
            var req = Utility.ExampleFileContent<Request.Type.Request>("LoadIndexListDataRequest.json");
            var loadIndex = Assert.IsType<LoadIndexListDataRequest>(req);
            Assert.True(Utility.CompareJson(loadIndex, "LoadIndexListDataRequest.json"));
        }

        [Fact]
        public void LoadTokenListData()
        {
            var req = Utility.ExampleFileContent<Request.Type.Request>("LoadTokenListDataRequest.json");
            var loadIndex = Assert.IsType<LoadTokenListDataRequest>(req);
            Assert.True(Utility.CompareJson(loadIndex, "LoadTokenListDataRequest.json"));
        }

        [Fact]
        public void RuntimeError()
        {
            var req = Utility.ExampleFileContent<Request.Type.Request>("RuntimeError.json");
            var errorReq = Assert.IsType<RuntimeErrorRequest>(req);
            Assert.True(Utility.CompareJson(errorReq, "RuntimeError.json"));
        }
    }
}
