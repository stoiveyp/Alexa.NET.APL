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
    public class APLDataSourceConverter : Newtonsoft.Json.JsonConverter
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Load JObject from stream
            var jObject = JObject.Load(reader);

            var target = GetDataSource(jObject.Value<string>("type"));
            serializer.Populate(jObject.CreateReader(), target);
            return target;
        }

        private static APLDataSource GetDataSource(string value)
        {
            return value switch
            {
                DynamicIndexList.DataSourceType => new DynamicIndexList(),
                ObjectDataSource.DataSourceType => new ObjectDataSource(),
                ListDataSource.DataSourceType => new ListDataSource(),
                DynamicTokenList.DataSourceType => new DynamicTokenList(),
                _ => (APLDataSource)new KeyValueDataSource()
            };
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().GetInterfaces().Contains(typeof(APLDataSource));
        }
    }
}