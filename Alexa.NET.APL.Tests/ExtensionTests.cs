using System.Linq;
using Alexa.NET.APL.Extensions.Backstack;
using Alexa.NET.APL.Extensions.EntitySensing;
using Alexa.NET.APL.Extensions.SmartMotion;
using Alexa.NET.Request;
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
            var backstack = new BackstackExtension("Back");
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
            var goBack = GoBackCommand.For(new BackstackExtension("Back"));
            Assert.True(JToken.DeepEquals(expected, JObject.FromObject(goBack)));
        }

        [Fact]
        public void BackStackGoBackFull()
        {
            var expected = new JObject {{"type", "Back:GoBack"}, {"backType", "id"}, {"backValue", "myDocument"}};
            var goBack = GoBackCommand.For(new BackstackExtension("Back"));
            goBack.BackType = BackTypeKind.Id;
            goBack.BackValue = "myDocument";
            Assert.True(JToken.DeepEquals(expected, JObject.FromObject(goBack)));
        }

        [Fact]
        public void BackstackClear()
        {
            var expected = new JObject { { "type", "Back:Clear" } };
            var goBack = ClearCommand.For(new BackstackExtension("Back"));
            Assert.True(JToken.DeepEquals(expected, JObject.FromObject(goBack)));
        }

        [Fact]
        public void SmartMotion()
        {
            var smartMotion = new SmartMotionExtension("SmartMotion");
            var doc = new APLDocument(APLDocumentVersion.V1_4);
            doc.Extensions.Value.Add(smartMotion);
            doc.Settings = new APLDocumentSettings();
            doc.Settings.Add(smartMotion.Name, new SmartMotionSettings
            {
                DeviceStateName = "MyDeviceState",
                WakeWordResponse = WakeWordResponse.FollowOnWakeWord
            });
            Assert.True(Utility.CompareJson(doc, "ExtensionSmartMotion.json"));
        }

        [Fact]
        public void FollowPrimaryUser()
        {
            var expected = new JObject { { "type", "SmartMotion:FollowPrimaryUser" } };
            var goBack = FollowPrimaryUserCommand.For(new SmartMotionExtension("SmartMotion"));
            Assert.True(JToken.DeepEquals(expected, JObject.FromObject(goBack)));
        }

        [Fact]
        public void GoToCenter()
        {
            var expected = new JObject { { "type", "SmartMotion:GoToCenter" } };
            var goBack = GoToCenterCommand.For(new SmartMotionExtension("SmartMotion"));
            Assert.True(JToken.DeepEquals(expected, JObject.FromObject(goBack)));
        }

        [Fact]
        public void SetWakeWordResponse()
        {
            var expected = new JObject { { "type", "SmartMotion:SetWakeWordResponse" }, {"wakeWordResponse", "turnToWakeWord"} };
            var setWake = SetWakeWordResponseCommand.For(new SmartMotionExtension("SmartMotion"));
            setWake.WakeWordResponse = WakeWordResponse.TurnToWakeWord;
            Assert.True(JToken.DeepEquals(expected, JObject.FromObject(setWake)));
        }

        [Fact]
        public void StopMotion()
        {
            var expected = new JObject { { "type", "SmartMotion:StopMotion" } };
            var stopMotion = StopMotionCommand.For(new SmartMotionExtension("SmartMotion"));
            Assert.True(JToken.DeepEquals(expected, JObject.FromObject(stopMotion)));
        }

        [Fact]
        public void TurnToPrimaryUser()
        {
            var expected = new JObject { { "type", "SmartMotion:TurnToPrimaryUser" } };
            var TurnToPrimaryUser = TurnToPrimaryUserCommand.For(new SmartMotionExtension("SmartMotion"));
            Assert.True(JToken.DeepEquals(expected, JObject.FromObject(TurnToPrimaryUser)));
        }

        [Fact]
        public void PlayNamedChoreo()
        {
            var expected = new JObject { { "type", "SmartMotion:PlayNamedChoreo" }, {"name","ScreenImpactCenter"} };
            var PlayNamedChoreo = PlayNamedChoreoCommand.For(new SmartMotionExtension("SmartMotion"), "ScreenImpactCenter");
            Assert.True(JToken.DeepEquals(expected, JObject.FromObject(PlayNamedChoreo)));
        }

        [Fact]
        public void DeviceStateChangedHandler()
        {
            var doc = new APLDocument();
            var smartMotion = new SmartMotionExtension("SmartMotion");
            smartMotion.OnDeviceStateChanged(doc, null);
            Assert.True(doc.Handlers.ContainsKey("SmartMotion:OnDeviceStateChanged"));
        }

        [Fact]
        public void EntitySensing()
        {
            var entitySensing = new EntitySensingExtension("EntitySensing");
            var doc = new APLDocument(APLDocumentVersion.V1_4);
            doc.Extensions.Value.Add(entitySensing);
            doc.Settings = new APLDocumentSettings();
            doc.Settings.Add(entitySensing.Name, new EntitySensingSettings
            {
                EntitySensingStateName = "EntitySensingState",
                PrimaryUserName = "User"
            });
            Assert.True(Utility.CompareJson(doc, "ExtensionEntitySensing.json"));
        }
    }
}
