
namespace Alexa.NET.APL.Extensions.Backstack
{
    public class ClearCommand : APLCommand
    {
        private readonly string _extensionName;

        public static ClearCommand For(BackstackExtension extension)
        {
            return new ClearCommand(extension.Name);
        }

        public ClearCommand(string extensionName)
        {
            _extensionName = extensionName;
        }

        public override string Type => $"{_extensionName}:Clear";
    }
}