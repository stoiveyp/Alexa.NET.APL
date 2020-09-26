namespace Alexa.NET.APL.Extensions.SmartMotion
{
    public class StopMotionCommand : APLCommand
    {
        private string _extensionName;

        public static StopMotionCommand For(SmartMotionExtension extension)
        {
            return new StopMotionCommand(extension.Name);
        }

        public StopMotionCommand(string extensionName)
        {
            _extensionName = extensionName;
        }

        public override string Type => $"{_extensionName}:StopMotion";
    }
}