﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class Sequence : ActionableComponent
    {
        public Sequence() { }

        public Sequence(params APLComponent[] items) : this((IEnumerable<APLComponent>)items) { }

        public Sequence(IEnumerable<APLComponent> items)
        {
            Items = items.ToList();
        }

        public override string Type => nameof(Sequence);

        [JsonProperty("data",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<object>> Data { get; set; }

        [JsonProperty("scrollDirection",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ScrollDirection { get; set; }

        [JsonProperty("firstItem",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLComponent>> FirstItem { get; set; }

        [JsonProperty("lastItem", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLComponent>> LastItem { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLComponent>> Items { get; set; }

        [JsonProperty("numbered",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> Numbered { get; set; }

        [JsonProperty("onScroll", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnScroll { get; set; }

        [JsonProperty("scaling",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Scaling { get; set; }

        [JsonProperty("snap", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<Snap>))]
        public APLValue<Snap?> Snap { get; set; }
    }
}
