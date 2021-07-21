using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaImageList: AlexaImageListBase
    {
        public override string Type => nameof(AlexaImageList);

        [JsonProperty("defaultImageSource",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> DefaultImageSource { get; set; }

        [JsonProperty("listItems",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<AlexaImageListItem>> ListItems { get; set; }

        [JsonProperty("videoAudioTrack", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> VideoAudioTrack { get; set; }

        [JsonProperty("videoAutoPlay", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> VideoAutoPlay { get; set; }

        [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Lang { get; set; }
    }
}
