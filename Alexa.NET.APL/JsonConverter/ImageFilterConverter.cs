using System;
using System.Linq;
using System.Reflection;
using Alexa.NET.APL.Filters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class ImageFilterConverter : Newtonsoft.Json.JsonConverter
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var filterType = jObject.Value<string>("type");
            object target = GetFilter(filterType);
            if (target == null)
            {
                throw new ArgumentOutOfRangeException($"Filter type {filterType} not supported");
            }

            try
            {
                serializer.Populate(jObject.CreateReader(), target);
            }
            catch (Exception)
            {
            }

            return target;

        }

        private IImageFilter GetFilter(string type)
        {
            switch (type)
            {
                case nameof(Blur):
                    return new Blur();
                default:
                    return null;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().ImplementedInterfaces.Contains(typeof(IImageFilter));
        }
    }
}
