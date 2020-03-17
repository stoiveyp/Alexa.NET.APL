using System.Collections.Generic;
using System.IO;
using System.Linq;
using Alexa.NET.APL.Components;
using Alexa.NET.APL.DataSources;
using Alexa.NET.APL.Filters;
using Alexa.NET.Response;
using Alexa.NET.Response.APL;
using Alexa.NET.Response.Directive;
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
            component.When = APLValue.To<bool?>("${@viewportProfile == @hubLandscapeSmall}");
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
        public void AalmadaTest()
        {
            var response = ResponseBuilder
                .Ask("Welcome to my skill. How can I help", new Reprompt());

            
                var json = JObject.FromObject(new APLDocument(APLDocumentVersion.V1_2));
                var launchTemplateApl = JObject.FromObject(json);

                var launchTemplateData = new ObjectDataSource
                {
                    ObjectId = "launchScreen",
                    Properties = new Dictionary<string, object>(),
                    TopLevelData = new Dictionary<string, object>(),
                };
                launchTemplateData.Properties.Add("textContent", "My Skill");
                launchTemplateData.Properties.Add("hintText", "Try, \"What can you do?\"");

                var directive = CreateAplDirective(launchTemplateApl, ("launchTemplateData", launchTemplateData));

                response.Response.Directives.Add(directive);
                var output = JsonConvert.SerializeObject(response);
        }

        static JsonDirective CreateAplDirective(JObject apl, params (string Key, ObjectDataSource Value)[] dataSources)
        {
            var directive = new JsonDirective(RenderDocumentDirective.APLDirectiveType);

            directive.Properties.Add("document", apl);

            var sources = new Dictionary<string, ObjectDataSource>();
            foreach (var (key, dataSource) in dataSources)
                sources.Add(key, dataSource);

            directive.Properties.Add("dataSources", JObject.FromObject(sources));

            return directive;
        }

        [Fact]
        public void ContainerTest()
        {
            var container = new Container
            (
                new Text("APL in C#")
                {
                    FontSize = "24dp",
                    TextAlign = "Center",
                },
                new Image(
                    "https://images.example.com/photos/2143/lights-party-dancing-music.jpg?cs=srgb&dl=cheerful-club-concert-2143.jpg&fm=jpg")
                {
                    Width = 400,
                    Height = 400,
                }
            );
        }

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
