﻿using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.Tests
{
    public static class Utility
    {
        private const string ExamplesPath = "Examples";

        public static bool CompareJson(object actual, string expectedFile)
        {
            var expected = ExampleFileContent(expectedFile);

            var actualJObject = JObject.FromObject(actual);
            var expectedJObject = JObject.Parse(expected);

            return JToken.DeepEquals(expectedJObject, actualJObject);
        }

        public static T ExampleFileContent<T>(string expectedFile)
        {
            APLSupport.Add();
            using (var reader = new JsonTextReader(new StringReader(ExampleFileContent(expectedFile))))
            {
                return new JsonSerializer().Deserialize<T>(reader);
            }
        }

        public static string ExampleFileContent(string expectedFile)
        {
            return File.ReadAllText(Path.Combine(ExamplesPath, expectedFile).Trim());
        }
    }
}
