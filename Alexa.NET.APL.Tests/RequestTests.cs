using System;
using Alexa.NET.APL.DataStore;
using Alexa.NET.APL.DataStore.PackageManager;
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

        [Fact]
        public void UsageInstalled()
        {
            var req = Utility.ExampleFileContent<Request.Type.Request>("UsagesInstalledRequest.json");
            var installedRequest = Assert.IsType<UsagesInstalledRequest>(req);

            Assert.Equal("WeatherWidget", installedRequest.Payload.PackageId);
            Assert.Equal("1.0.0", installedRequest.Payload.PackageVersion);

            var usage = Assert.Single(installedRequest.Payload.Usages);
            Assert.Equal("amzn1.ask.package.v1.instance.v1.{uuid}",usage.InstanceId);
            Assert.Equal("FAVORITE",usage.Location);
        }

        [Fact]
        public void UsageRemoved()
        {
            var req = Utility.ExampleFileContent<Request.Type.Request>("UsagesRemovedRequest.json");
            var removedRequest = Assert.IsType<UsagesRemovedRequest>(req);

            Assert.Equal("WeatherWidget", removedRequest.Payload.PackageId);
            Assert.Equal("1.0.0", removedRequest.Payload.PackageVersion);

            var usage = Assert.Single(removedRequest.Payload.Usages);
            Assert.Equal("amzn1.ask.package.v1.instance.v1.{uuid}", usage.InstanceId);
            Assert.Equal("FAVORITE", usage.Location);
        }

        [Fact]
        public void UsageUpdate()
        {
            var req = Utility.ExampleFileContent<Request.Type.Request>("UsageUpdateRequest.json");
            var removedRequest = Assert.IsType<UpdateRequest>(req);

            Assert.Equal("WeatherWidget", removedRequest.PackageId);
            Assert.Equal("1.0.0", removedRequest.FromVersion);
            Assert.Equal("1.0.1", removedRequest.ToVersion);
        }

        [Fact]
        public void InstallationError()
        {
            var req = Utility.ExampleFileContent<Request.Type.Request>("InstallationError.json");
            var err = Assert.IsType<InstallationError>(req);

            Assert.Equal("WeatherWidget", err.PackageId);
            Assert.Equal("1.0.0", err.Version);
            Assert.Equal("PACKAGEMANAGER_INTERNAL_ERROR", err.Error.Type);
        }

        [Fact]
        public void DataStoreErrorStorage()
        {
            var req = Utility.ExampleFileContent<Request.Type.Request>("DataStoreError_Storage.json");
            var typedReq = Assert.IsType<DataStoreErrorRequest>(req);
            var err = Assert.IsType<DataStoreStorageError>(typedReq.Error);

            Assert.Equal("STORAGE_LIMIT_EXCEEDED", err.Type);
            Assert.Equal("device-id", err.Content.DeviceId);
            Assert.NotNull(err.Content.FailedCommand);
        }

        [Fact]
        public void DataStoreErrorDevice()
        {
            var req = Utility.ExampleFileContent<Request.Type.Request>("DataStoreError_Device.json");
            var typedReq = Assert.IsType<DataStoreErrorRequest>(req);
            var err = Assert.IsType<DataStoreDeviceError>(typedReq.Error);

            Assert.Equal("DEVICE_UNAVAILABLE", err.Type);
            Assert.Equal("device-id", err.Content.DeviceId);
            Assert.Single(err.Content.Commands);
        }
    }
}
