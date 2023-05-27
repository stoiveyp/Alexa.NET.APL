using System.Collections.Generic;

namespace Alexa.NET.APL.Extensions.DataStore
{
    public class DataStoreExtension:APLExtension
    {
        public const string URL = "alexaext:datastore:10";
        public const string ObjectChangedEventName = "OnObjectChanged";
        public const string ObjectReceivedEventName = "OnObjectReceived";

        public DataStoreExtension()
        {
            Uri = URL;
        }

        public DataStoreExtension(string name) : this()
        {
            Name = name;
        }

        public void OnObjectChanged(APLDocumentBase document, APLValue<IList<APLCommand>> commands)
        {
            document.AddHandler($"{Name}:{ObjectChangedEventName}", commands);
        }

        public void OnObjectReceived(APLDocumentBase document, APLValue<IList<APLCommand>> commands)
        {
            document.AddHandler($"{Name}:{ObjectReceivedEventName}", commands);
        }
    }
}
