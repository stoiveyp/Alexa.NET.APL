using System;
using System.Collections.Generic;
using Alexa.NET.APL.DataStore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class DataStoreErrorConverter: JsonConverter<DataStoreError>
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, DataStoreError value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override DataStoreError ReadJson(JsonReader reader, Type objectType, DataStoreError existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var commandType = jObject.Value<string>("type");
            var target = GetContentType(commandType);
            if (target != null)
            {
                serializer.Populate(jObject.CreateReader(), target);
                return target;
            }

            throw new ArgumentOutOfRangeException($"Error type {commandType} not supported");
        }

        public static Dictionary<string, Type> DataStoreErrorLookup = new Dictionary<string, Type>
        {
            { "STORAGE_LIMIT_EXCEEDED", typeof(DataStoreStorageError) },
            { "DATASTORE_INTERNAL_ERROR", typeof(DataStoreStorageError) },
            { "DEVICE_UNAVAILABLE", typeof(DataStoreDeviceError) },
            { "DEVICE_PERMANENTLY_UNAVAILABLE", typeof(DataStoreDeviceError) },
            { "INVALID_TARGET", typeof(DataStoreDeviceError)}
        };

        private DataStoreError GetContentType(string commandType)
        {
            return (DataStoreError)(
                DataStoreErrorLookup.ContainsKey(commandType)
                    ? Activator.CreateInstance(DataStoreErrorLookup[commandType])
                    : null);
        }
    }
}