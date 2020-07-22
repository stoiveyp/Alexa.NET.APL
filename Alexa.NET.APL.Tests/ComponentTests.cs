using System.Collections.Generic;
using System.IO;
using System.Linq;
using Alexa.NET.APL.Commands;
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
        public void AlexaIconButton()
        {
            var control = new AlexaIconButton
            {
                ButtonSize = new AbsoluteDimension(72, "dp"),
                VectorSource =
                    "M21.343,8.661l-7.895-7.105c-0.823-0.741-2.073-0.741-2.896,0L2.657,8.661C2.238,9.039,2,9.564,2,10.113V20c0,1.105,0.943,2,2.105,2H9v-9h6v9h4.895C21.057,22,22,21.105,22,20v-9.887C22,9.564,21.762,9.039,21.343,8.661z",
                PrimaryAction = new APLCommand[]{new SetValue
                {
                    ComponentId = "textToUpdate",
                    Property = "text",
                    Value = APLValue.To<string>("${exampleData.imageStyleText}")
                }}.ToList()
            };
            Assert.True(Utility.CompareJson(control,"AlexaIconButton.json"));
        }

        [Fact]
        public void AlexaImageListItem()
        {
            var control = new AlexaImageListItem
            {
                Theme = "dark",
                PrimaryText = "${exampleData.primaryText}",
                SecondaryText = "${exampleData.secondaryText}",
                TertiaryText = "${exampleData.tertiaryText}",
                ProviderText = "${exampleData.providerText}",
                ImageProgressBarPercentage = 75,
                ImageRoundedCorner = true,
                ImageAspectRatio = AlexaImageAspectRatio.Square,
                ImageSource = "${exampleData.imageSource}"
            };
            Assert.True(Utility.CompareJson(control,"AlexaImageListItem.json"));
        }


        [Fact]
        public void AlexaRating()
        {
            var control = new AlexaRating
            {
                RatingSlotPadding = new AbsoluteDimension(0,"dp"),
                RatingSlotMode = RatingSlotMode.Multiple,
                RatingNumber = 3.5,
                RatingText = "509 ratings",
                Spacing = "@spacingMedium"
            };
            Assert.True(Utility.CompareJson(control,"AlexaRating.json"));
        }

        [Fact]
        public void AlexaImageList()
        {
            var control = new AlexaImageList
            {
                ListItems = APLValue.To<IList<AlexaImageListItem>>("${imageListData.listItemsToShow}"),
                DefaultImageSource = "https://d2o906d8ln7ui1.cloudfront.net/images/BT7_Background.png",
                ImageBlurredBackground = true,
                PrimaryAction = (new APLCommand[]
                {
                    new SendEvent
                    {
                        Arguments = new[]{"ListItemSelected", "${ordinal}"}.ToList()
                    }
                }.ToList())
            };
            Assert.True(Utility.CompareJson(control,"AlexaImageList.json"));
        }

        [Fact]
        public void AlexaLists()
        {
            var control = new AlexaLists
            {
                ListItems = APLValue.To<IList<AlexaListItem>>("${listData.listItemsToShow}"),
                ListImagePrimacy = true,
                DefaultImageSource = "https://d2o906d8ln7ui1.cloudfront.net/images/BT7_Background.png",
                ImageBlurredBackground = true
            };

            Assert.True(Utility.CompareJson(control, "AlexaLists.json"));
        }

        [Fact]
        public void AlexaPaginatedList()
        {
            Utility.AssertSerialization<AlexaPaginatedList>("AlexaPaginatedList.json");
        }

        [Fact]
        public void TickHandler()
        {
            Utility.AssertSerialization<Container>("TickHandler.json");
        }

        [Fact]
        public void ProgressBar()
        {
            Utility.AssertSerialization<AlexaProgressBar>("AlexaProgressBar.json");
        }

        [Fact]
        public void ProgressBarRadial()
        {
            Utility.AssertSerialization<Container>("AlexaProgressBarRadial.json");
        }

        [Fact]
        public void DictionaryBindingTest()
        {
            var rawContainer = new Container
            {
                Data = new[]{new Dictionary<string, object> { { "test", "thing" } }},
            };
            var dataBoundContainer = new Container
            {
                Data = APLValue.To<IList<object>>("$data.random.stuff")
            };

            var rawJson = JsonConvert.SerializeObject(rawContainer);
            var boundJson = JsonConvert.SerializeObject(dataBoundContainer);

            var newRaw = JsonConvert.DeserializeObject<APLComponent>(rawJson);
            var newBound = JsonConvert.DeserializeObject<APLComponent>(boundJson);

            var newRawContainer = Assert.IsType<Container>(newRaw);
            var newBoundContainer = Assert.IsType<Container>(newBound);

            Assert.Single((JObject)newRawContainer.Data.Value.First());
            Assert.Equal("$data.random.stuff", newBoundContainer.Data.Expression);
        }

        private APLComponent GenerateComponent(string componentType)
        {
            var json = new JObject { { "type", componentType }, { "numbered", true } };
            return JsonConvert.DeserializeObject<APLComponent>(json.ToString());
        }
    }
}
