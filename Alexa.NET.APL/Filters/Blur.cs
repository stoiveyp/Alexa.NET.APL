using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Filters
{
    public class Blur:IImageFilter
    {
        [JsonProperty("radius",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue Radius { get; set; }
        public Blur() { }

        public Blur(Dimension radius)
        {
            Radius = radius;
        }

        public string Type => nameof(Blur);
    }
}
