using System.Linq;
using Alexa.NET.APL.Components;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class ComponentTests
    {
        [Fact]
        public void ComponentTypes()
        {
            var result = GenerateComponent("Container");
            Assert.IsType<Container>(result);

            result = GenerateComponent("Text");
            Assert.IsType<Text>(result);


        }

        [Fact]
        public void Bindings()
        {
            var component = Utility.ExampleFileContent<Text>("Binding.json");
            Assert.Equal(2,component.Bindings.Count);

            var first = component.Bindings.First();
            Assert.Equal("foo",first.Name);
            Assert.Equal("27",first.Value);

            var second = component.Bindings.Skip(1).First();
            Assert.Equal("bar",second.Name);
            Assert.Equal("${foo + 23}", second.Value);
        }

        private APLComponent GenerateComponent(string componentType)
        {
            var json = new JObject {{"type", componentType}};
            return JsonConvert.DeserializeObject<APLComponent>(json.ToString());
        }
    }
}
