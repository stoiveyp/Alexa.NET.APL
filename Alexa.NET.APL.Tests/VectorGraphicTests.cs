using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.VectorGraphics;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class VectorGraphicTests
    {
        [Fact]
        public void AVGGeneratesCorrectJson()
        {
            var items = new List<IAVGItem>
            {
                new AVGPath
                {
                    Fill = "red",
                    Stroke = "blue",
                    StrokeWidth = 4,
                    PathData = "M 50 0 L 100 50 L 50 100 L 0 50 z"
                }
            };

            var avg = new AVG
            {
                Height = 100,
                Width = 100,
                Items = new APLValue<IList<IAVGItem>>(items)
            };
            Assert.True(Utility.CompareJson(avg,"AVG.json"));

            var avgdeserial = Utility.ExampleFileContent<AVG>("AVG.json");
            var item = Assert.Single(avgdeserial.Items.Value);
            Assert.IsType<AVGPath>(item);
        }
    }
}
