using System;
using System.Collections.Generic;
using System.Reflection;
using Alexa.NET.APL.Components;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLComponentConverter : Newtonsoft.Json.JsonConverter
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Load JObject from stream
            var jObject = JObject.Load(reader);
            var componentType = jObject.Value<string>("type");
            object target = GetComponent(componentType);
            if (target == null)
            {
                throw new ArgumentOutOfRangeException($"Component type {componentType} not supported");
            }

            if ((target is Frame || target is TouchWrapper) && jObject["items"] != null)
            {
                jObject["item"] = jObject["items"];
                jObject.Remove("items");
            }

            if ((target is Container || target is Pager) && jObject["item"] != null)
            {
                jObject["items"] = jObject["item"];
                jObject.Remove("item");
            }

            try
            {
                serializer.Populate(jObject.CreateReader(), target);
            }
            catch (Exception)
            {
            }

            if (target is CustomComponent custom)
            {
                custom.Properties.Remove("type");
            }

            return target;

        }

        public static Dictionary<string, Type> APLComponentLookup = new Dictionary<string, Type>
        {
            {nameof(Container), typeof(Container)},
            {nameof(Text), typeof(Text)},
            {nameof(Image), typeof(Image)},
            {nameof(Frame), typeof(Frame)},
            {nameof(ScrollView), typeof(ScrollView)},
            {nameof(Sequence), typeof(Sequence)},
            {nameof(TouchWrapper), typeof(TouchWrapper)},
            {nameof(Pager), typeof(Pager)},
            {nameof(VectorGraphic),typeof(VectorGraphic) },
            {nameof(Video), typeof(Video)},
            {nameof(AlexaBackground), typeof(AlexaBackground)},
            {nameof(AlexaButton),typeof(AlexaButton) },
            {nameof(AlexaDivider),typeof(AlexaDivider) },
            {nameof(AlexaFooter),typeof(AlexaFooter) },
            {nameof(AlexaHeader),typeof(AlexaHeader) },
            {nameof(AlexaImage),typeof(AlexaImage) },
            {nameof(AlexaOrdinal),typeof(AlexaOrdinal) },
            {nameof(AlexaPageCounter),typeof(AlexaPageCounter) },
            {nameof(AlexaTextListItem),typeof(AlexaTextListItem) },
            {nameof(AlexaTransportControls),typeof(AlexaTransportControls) },
            {nameof(AlexaHeadline),typeof(AlexaHeadline) },
            {nameof(AlexaTextList),typeof(AlexaTextList) },
            {nameof(TimeText),typeof(TimeText) }
        };

        private APLComponent GetComponent(string type)
        {
            return (APLComponent)(
                APLComponentLookup.ContainsKey(type)
                    ? Activator.CreateInstance(APLComponentLookup[type])
                    : new CustomComponent(type));
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().IsSubclassOf(typeof(APLComponent));
        }
    }
}