using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class ViewportConverter:JsonConverter<Viewport>
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, Viewport value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override Viewport ReadJson(JsonReader reader, Type objectType, Viewport existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var viewportType = jObject.Value<string>("type");

            if (viewportType == null)
            {
                return null;
            }

            if (viewportType == "APL")
            {
                var apl = new APLViewport();
                serializer.Populate(jObject.CreateReader(), apl);
                return apl;
            }

            if (viewportType == "APLT")
            {
                var aplt = new APLTViewport();
                serializer.Populate(jObject.CreateReader(), aplt);
                return aplt;
            }

            throw new InvalidOperationException($"Unknown APL Document type {viewportType}");
        }
    }
}
