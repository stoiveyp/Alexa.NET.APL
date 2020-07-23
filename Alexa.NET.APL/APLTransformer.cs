using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.APL
{
    public class APLTransformer
    {
        public APLTransformer() { }

        public APLTransformer(string transformerType, string outputName)
        {
            Transformer = transformerType;
            OutputName = outputName;
        }

        public APLTransformer(string transformerType, string inputPath, string outputName)
        {
            Transformer = transformerType;
            InputPath = inputPath;
            OutputName = outputName;
        }

        [JsonProperty("inputPath", NullValueHandling = NullValueHandling.Ignore)]
        public string InputPath { get; set; }

        [JsonProperty("outputName",NullValueHandling = NullValueHandling.Ignore)]
        public string OutputName { get; set; }

        [JsonProperty("transformer")]
        public string Transformer { get; set; }

        [JsonProperty("template",NullValueHandling = NullValueHandling.Ignore)]
        public string Template { get; set; }

        public static APLTransformer SsmlToSpeech(string inputPath, string outputName)
        {
            return new APLTransformer("ssmlToSpeech",inputPath,outputName);
        }

        public static APLTransformer SsmlToText(string inputPath, string outputName)
        {
            return new APLTransformer("ssmlToText", inputPath, outputName);
        }

        public static APLTransformer TextToHint(string inputPath, string outputName)
        {
            return new APLTransformer("textToHint", inputPath, outputName);
        }

        public static APLTransformer TextToSpeech(string inputPath, string outputName)
        {
            return new APLTransformer("textToSpeech",inputPath,outputName);
        }

        public static APLTransformer AplAudioToSpeech(string template, string outputName)
        {
            return new APLTransformer("aplAudioToSpeech", outputName){Template=template};
        }
    }
}
