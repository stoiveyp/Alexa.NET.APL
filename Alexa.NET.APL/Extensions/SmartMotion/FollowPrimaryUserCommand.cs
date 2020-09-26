using System;
using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.APL.Extensions.SmartMotion
{
    public class FollowPrimaryUserCommand:APLCommand
    {
        private string _extensionName;

        public static FollowPrimaryUserCommand For(SmartMotionExtension extension)
        {
            return new FollowPrimaryUserCommand(extension.Name);
        }

        public FollowPrimaryUserCommand(string extensionName)
        {
            _extensionName = extensionName;
        }

        public override string Type => $"{_extensionName}:FollowPrimaryUser";
    }
}
