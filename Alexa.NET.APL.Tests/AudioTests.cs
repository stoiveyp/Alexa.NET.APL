using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.Audio;
using Alexa.NET.Response;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class AudioTests
    {
        [Fact]
        public void APLADocument()
        {
            Utility.AssertSerialization<APLADocument>("APLADocument.json");
        }

        [Fact]
        public void APLARenderDocument()
        {
            Utility.AssertSerialization<RenderDocumentDirective>("APLARenderDocument.json");
        }

        [Fact]
        public void Audio()
        {
            Utility.AssertSerialization<Audio.Audio>("Audio_AudioFilters.json");
        }

        [Fact]
        public void Mixer()
        {
            Utility.AssertSerialization<Mixer>("Audio_Mixer.json");
        }

        [Fact]
        public void Selector()
        {
            Utility.AssertSerialization<Selector>("Audio_Selector.json");
        }

        [Fact]
        public void Sequencer()
        {
            Utility.AssertSerialization<Sequencer>("Audio_Sequencer.json");
        }

        [Fact]
        public void Silence()
        {
            Utility.AssertSerialization<Silence>("Audio_Silence.json");
        }

        [Fact]
        public void Speech()
        {
            Utility.AssertSerialization<Speech>("Audio_Speech.json");
        }
    }
}
