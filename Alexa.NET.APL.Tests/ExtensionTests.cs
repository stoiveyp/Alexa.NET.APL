using Alexa.NET.APL.Extensions;
using Alexa.NET.Response.APL;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class ExtensionTests
    {
        [Fact]
        public void BackStackExtension()
        {
            var backstack = new BackStack("Back");
            var doc = new APLDocument(APLDocumentVersion.V1_4);
            doc.Extensions.Value.Add(backstack);
            doc.Settings = new APLDocumentSettings(); 
            doc.Settings.Add(backstack.Name, new BackStackSettings{BackstackId = "myDocument"});
            Assert.True(Utility.CompareJson(doc, "ExtensionBackStack.json"));
        }
    }
}
