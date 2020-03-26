using System;
using System.Collections.Generic;
using System.Text;
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
        public void RuntimeError()
        {
            var req = Utility.ExampleFileContent<Request.Type.Request>("RuntimeError.json");
            var errorReq = Assert.IsType<RuntimeErrorRequest>(req);
            Assert.True(Utility.CompareJson(errorReq, "RuntimeError.json"));
        }
    }
}
