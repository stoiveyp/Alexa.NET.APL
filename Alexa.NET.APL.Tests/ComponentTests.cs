using System.Collections.Generic;
using System.Linq;
using Alexa.NET.APL.Components;
using Alexa.NET.APL.Filters;
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
            Assert.Equal(2, component.Bindings.Count);

            var first = component.Bindings.First();
            Assert.Equal("foo", first.Name);
            Assert.Equal("27", first.Value);

            var second = component.Bindings.Skip(1).First();
            Assert.Equal("bar", second.Name);
            Assert.Equal("${foo + 23}", second.Value);
        }

        [Fact]
        public void RandomClassTest()
        {
            var component = GenerateComponent("random");
            Assert.IsType<CustomComponent>(component);
            Assert.Single(((CustomComponent)component).Properties);
        }

        //[Fact]
        //public void VideoComponent()
        //{
        //    var component = new Video { Autoplay = true };
        //    var sources = VideoSource.FromUrl("https://examplevideo.com/video.mp4");
        //    component.Source = sources;
        //    Assert.True(Utility.CompareJson(component, "Video.json"));
        //}

        [Fact]
        public void APLComponentValue()
        {
            var text = new Text("Hello World")
            {
                Color = APLValue.To<string>("${color}"),
                Disabled = APLValue.To<bool?>("${disabled}"),
                FontSize = "24dp",
                Left = new AbsoluteDimension(24, "vw"),
                PaddingLeft = new RelativeDimension(5),
                Top = "${top}",
                Right = new APLAbsoluteDimensionValue("345"),
                Bottom = new APLAbsoluteDimensionValue("test")

            };

            var jobject = JObject.FromObject(text);
            Assert.Equal("24dp", jobject.Value<string>("fontSize"));
            Assert.Equal("24vw", jobject.Value<string>("left"));
            Assert.Equal("5%", jobject.Value<string>("paddingLeft"));
            Assert.Equal("${top}", jobject.Value<string>("top"));
            Assert.Equal("345", jobject.Value<string>("right"));
            Assert.Equal("test", jobject.Value<string>("bottom"));
        }

        [Fact]
        public void ImageWithBlur()
        {
            var image = new Image
            {
                Filters = new IImageFilter[]
                {
                    new Blur(Dimension.From("10dp")),
                }
            };

            Assert.True(Utility.CompareJson(image, "ImageWithBlur.json"));
        }

        [Fact]
        public void TimeText()
        {
            var timeText = new TimeText
            {
                Direction = TimeTextDirection.Down,
                Format = "%M:%S",
                Start = 1552070232
            };

            Assert.True(Utility.CompareJson(timeText, "TimeText.json"));
        }

        [Fact]
        public void KeyboardEvent()
        {
            var component = Utility.ExampleFileContent<APLComponent>("KeyboardTouchWrapper.json");
            var touch = Assert.IsType<TouchWrapper>(component);
            Assert.Equal(2, touch.Bindings.Count);
            Assert.Equal(5, touch.HandleKeyDown.Value.Count);
            var keydown = touch.HandleKeyDown.Value.First();

            Assert.Equal("${event.keyboard.code == 'KeyW'}", keydown.When.Expression);
            Assert.Single(keydown.Commands.Value);
        }

        [Fact]
        public void DictionaryBindingTest()
        {
            var rawContainer = new Container
            {
                Data = new Dictionary<string, object> { { "test", "thing" } },
            };
            var dataBoundContainer = new Container
            {
                Data = APLValue.To<Dictionary<string, object>>("$data.random.stuff")
            };

            var rawJson = JsonConvert.SerializeObject(rawContainer);
            var boundJson = JsonConvert.SerializeObject(dataBoundContainer);

            var newRaw = JsonConvert.DeserializeObject<APLComponent>(rawJson);
            var newBound = JsonConvert.DeserializeObject<APLComponent>(boundJson);

            var newRawContainer = Assert.IsType<Container>(newRaw);
            var newBoundContainer = Assert.IsType<Container>(newBound);

            Assert.Single(newRawContainer.Data.Value);
            Assert.Equal("$data.random.stuff", newBoundContainer.Data.Expression);
        }

        private APLComponent GenerateComponent(string componentType)
        {
            var json = new JObject { { "type", componentType }, { "numbered", true } };
            return JsonConvert.DeserializeObject<APLComponent>(json.ToString());
        }
    }
}
