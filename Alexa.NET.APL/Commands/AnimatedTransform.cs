using System.Collections.Generic;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class AnimatedTransform : AnimatedProperty
    {
        [JsonProperty("property")]
        public override APLValue<string> Property => "transform";

        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<APLTransform>> From { get; set; }

        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<APLTransform>> To { get; set; }

        public IList<AnimatedProperty> Multiple(IEnumerable<APLTransform> from, IEnumerable<APLTransform> to)
        {
            return new List<AnimatedProperty>
                {
                    new AnimatedTransform
                    {
                        From = new List<APLTransform>(from),
                        To = new List<APLTransform>(to)
                    }
                };
        }

        public IList<AnimatedProperty> Single(APLTransform from, APLTransform to)
        {
            return new List<AnimatedProperty>
            {
                new AnimatedTransform
                {
                    From = new List<APLTransform>
                    {
                        from
                    },
                    To = new List<APLTransform>
                    {
                        to
                    }
                }
            };
        }
    }
}