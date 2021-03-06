﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
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
            object target = ImageFilterLookup.GetLookupType<IImageFilter>(filterType, "Alexa.NET.APL.Filters", s => null);
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

        public static ConcurrentDictionary<string,Type> ImageFilterLookup = new ConcurrentDictionary<string, Type>();

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().ImplementedInterfaces.Contains(typeof(IImageFilter));
        }
    }
}
