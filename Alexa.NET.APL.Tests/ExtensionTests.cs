using Alexa.NET.APL.Extensions;
using Alexa.NET.Response.APL;
using Newtonsoft.Json.Linq;
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

        [Fact]
        public void BackStackGoBack()
        {
            var expected = new JObject {{"type", "Back:GoBack"}};
            var goBack = BackstackGoBackCommand.For(new BackStack("Back"));
            Assert.True(JToken.DeepEquals(expected, JObject.FromObject(goBack)));
        }

        [Fact]
        public void BackStackGoBackFull()
        {
            var expected = new JObject {{"type", "Back:GoBack"}, {"backType", "id"}, {"backValue", "myDocument"}};
            var goBack = BackstackGoBackCommand.For(new BackStack("Back"));
            goBack.BackType = BackTypeKind.Id;
            goBack.BackValue = "myDocument";
            Assert.True(JToken.DeepEquals(expected, JObject.FromObject(goBack)));
        }

        [Fact]
        public void BackstackClear()
        {
            var expected = new JObject { { "type", "Back:Clear" } };
            var goBack = BackstackClearCommand.For(new BackStack("Back"));
            Assert.True(JToken.DeepEquals(expected, JObject.FromObject(goBack)));
        }
    }
}
