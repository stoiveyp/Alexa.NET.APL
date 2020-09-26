namespace Alexa.NET.APL.Extensions
{
    public class BackstackClearCommand : APLCommand
    {
        private readonly string _extensionName;

        public static BackstackClearCommand For(BackStack extension)
        {
            return new BackstackClearCommand(extension.Name);
        }

        public BackstackClearCommand(string extensionName)
        {
            _extensionName = extensionName;
        }

        public override string Type => $"{_extensionName}:Clear";
    }
}