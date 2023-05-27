using System;
using System.Collections.Generic;
using System.Reflection;
using Alexa.NET.APL.DataStore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class DataStoreCommandConverter : Newtonsoft.Json.JsonConverter
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {

            var jObject = JObject.Load(reader);
            var commandType = jObject.Value<string>("type");

            object target;
            if (commandType == PutObject.CommandType)
            {
                if (jObject.GetValue("content") is JArray)
                {
                    target = new PutObjectArray();
                }
                else
                {
                    target = new PutObject();
                }
            }
            else
            {
                target = GetCommand(commandType);
            }

            if (target != null)
            {
                serializer.Populate(jObject.CreateReader(), target);
                return target;
            }

            throw new ArgumentOutOfRangeException($"Command type {commandType} not supported");
        }

        public static Dictionary<string, Type> DataStoreCommandLookup = new Dictionary<string, Type>
        {
            {PutNamespace.CommandType, typeof(PutNamespace)},
            {RemoveNamespace.CommandType, typeof(RemoveNamespace)},
            {Clear.CommandType, typeof(Clear)}
        };

        private DataStoreCommand GetCommand(string commandType)
        {
            return (DataStoreCommand)(
                DataStoreCommandLookup.ContainsKey(commandType)
                    ? Activator.CreateInstance(DataStoreCommandLookup[commandType])
                    : null);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().IsSubclassOf(typeof(DataStoreCommand));
        }
    }
}
