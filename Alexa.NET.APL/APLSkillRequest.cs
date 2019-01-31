using Alexa.NET.APL;
using Newtonsoft.Json;

namespace Alexa.NET.Request
{
    public class APLSkillRequest:SkillRequest
    {
        private APLContext _context;

        [JsonProperty("context")]
        public new APLContext Context
        {
            get => _context;
            set
            {
                base.Context = value;
                _context = value;
            }
        }
    }
}
