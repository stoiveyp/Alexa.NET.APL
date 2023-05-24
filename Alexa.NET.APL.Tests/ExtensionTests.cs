using System.Collections.Generic;
using System.Linq;
using Alexa.NET.APL.Extensions.Backstack;
using Alexa.NET.APL.Extensions.DataStore;
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

        [Fact]
        public void EntitySensingStateChanged()
        {
            var doc = new APLDocument();
            var entitySensing = new EntitySensingExtension("EntitySensing");
            entitySensing.OnEntitySensingStateChanged(doc, null);
            Assert.True(doc.Handlers.ContainsKey("EntitySensing:OnEntitySensingStateChanged"));
        }

        [Fact]
        public void PrimaryUserChanged()
        {
            var doc = new APLDocument();
            var entitySensing = new EntitySensingExtension("EntitySensing");
            entitySensing.OnPrimaryUserChanged(doc, null);
            Assert.True(doc.Handlers.ContainsKey("EntitySensing:OnPrimaryUserChanged"));
        }

        [Fact]
        public void DataStore()
        {
            var dataStore = new DataStoreExtension("DataStore");
            var doc = new APLDocument(APLDocumentVersion.V2023_1);
            doc.Extensions.Value.Add(dataStore);
            doc.Settings = new APLDocumentSettings();
            doc.Settings.Add(dataStore.Name, new DataStoreSettings
            {
                DataBindings = new()
                {
                    new DataBinding
                    {
                        Namespace = "LocationWeather",
                        Key="weather",
                        DataBindingName = "DS_Weather"
                    }
                }
            });
            Assert.True(Utility.CompareJson(doc, "DataStore_Extension.json"));
        }

        [Fact]
        public void DataStoreGetObject()
        {
            var expected = new JObject
            {
                { "type", "DataStore:GetObject" }, 
                { "namespace", "LocationWeather" },
                { "key", "weather" },
                { "token", "thisIsADummyToken" }
            };
            var getobj = GetObjectCommand.For(new DataStoreExtension("DataStore"), "LocationWeather",
                "weather", "thisIsADummyToken");
            Assert.True(JToken.DeepEquals(expected, JObject.FromObject(getobj)));
        }

        [Fact]
        public void DataStoreWatchObject()
        {
            var expected = new JObject
            {
                { "type", "DataStore:WatchObject" },
                { "namespace", "LocationWeather" },
                { "key", "weather" },
            };
            var getobj = WatchObjectCommand.For(new DataStoreExtension("DataStore"), "LocationWeather", "weather");
            Assert.True(JToken.DeepEquals(expected, JObject.FromObject(getobj)));
        }

        [Fact]
        public void DataStoreUnwatchObject()
        {
            var expected = new JObject
            {
                { "type", "DataStore:UnwatchObject" },
                { "namespace", "LocationWeather" },
                { "key", "weather" },
            };
            var getobj = UnwatchObjectCommand.For(new DataStoreExtension("DataStore"), "LocationWeather", "weather");
            Assert.True(JToken.DeepEquals(expected, JObject.FromObject(getobj)));
        }

        [Fact]
        public void DataStoreUpdateArrayBindingRange()
        {
            var expected = new JObject
            {
                { "type", "DataStore:UpdateArrayBindingRange" },
                { "dataBindingName", "ToDoNotes" },
                { "startIndex", "${test}"},
                { "endIndex", 5},
            };
            var getobj = UpdateArrayBindingRangeCommand.For(new DataStoreExtension("DataStore"), "ToDoNotes",APLValue.To<int?>("${test}"),5);
            Assert.True(JToken.DeepEquals(expected, JObject.FromObject(getobj)));
        }
    }
}
