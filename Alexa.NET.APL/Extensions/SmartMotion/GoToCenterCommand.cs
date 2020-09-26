namespace Alexa.NET.APL.Extensions.SmartMotion
{
    public class GoToCenterCommand : APLCommand
    {
        private string _extensionName;

        public static GoToCenterCommand For(SmartMotionExtension extension)
        {
            return new GoToCenterCommand(extension.Name);
        }

        public GoToCenterCommand(string extensionName)
        {
            _extensionName = extensionName;
        }

        public override string Type => $"{_extensionName}:GoToCenter";
    }
}