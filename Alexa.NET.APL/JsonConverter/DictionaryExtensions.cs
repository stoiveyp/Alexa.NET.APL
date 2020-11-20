using System;
using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.APL.JsonConverter
{
    internal static class DictionaryExtensions
    {
        internal static T GetLookupType<T>(this Dictionary<string, Type> dictionary, string typeName,
            string typeNamespace, Func<string, T> defaultValue)
        {
            if (dictionary.ContainsKey(typeName))
            {
                return (T)Activator.CreateInstance(dictionary[typeName]);
            }

            var resultingType = Type.GetType(typeNamespace + "." + typeName);
            if (resultingType != null)
            {
                try
                {
                    if (!dictionary.ContainsKey(typeName))
                    {
                        dictionary.Add(typeName, resultingType);
                    }
                }
                catch(ArgumentException)
                {
                    
                }

                return (T)Activator.CreateInstance(resultingType);
            }

            return defaultValue(typeName);
        }
    }
}
