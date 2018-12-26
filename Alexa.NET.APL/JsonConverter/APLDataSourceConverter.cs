using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Alexa.NET.APL.DataSources;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLDataSourceConverter:Newtonsoft.Json.JsonConverter
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Load JObject from stream
            var jObject = JObject.Load(reader);

            // Create target request object based on "type" property
            if(jObject.Value<string>("type") == "object")
            {
                if (jObject.Value<JObject>("properties") == null)
                {
                    jObject.Remove("type");
                    var dynamic = new ObjectDynamicDataSource();
                    serializer.Populate(jObject.CreateReader(), dynamic);
                    return ObjectDataSource.From(dynamic);
                }

                var target = new ObjectDataSource();
                serializer.Populate(jObject.CreateReader(), target);
                return target;
            }
            else
            {
                var target = new KeyValueDataSource();
                serializer.Populate(jObject.CreateReader(),target);
                return target;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().GetInterfaces().Contains(typeof(APLDataSource));
        }
    }
}