using System;
using System.ComponentModel;
using System.Linq;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLDataSourceConverter:Newtonsoft.Json.JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer,value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Load JObject from stream
            var jObject = JObject.Load(reader);

            // Create target request object based on "type" property
            if(jObject["type"].ToString() == "object")
            {
                var target = new ObjectDataSource();
                serializer.Populate(jObject.CreateReader(), target);
                return target;
            }

            throw new InvalidEnumArgumentException("Only object data sources currently supported");
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetInterfaces().Contains(typeof(IAPLDataSource));
        }
    }
}