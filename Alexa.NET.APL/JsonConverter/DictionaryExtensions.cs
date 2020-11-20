using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.APL.JsonConverter
{
    internal static class DictionaryExtensions
    {
        internal static T GetLookupType<T>(this ConcurrentDictionary<string, Type> dictionary, string typeName,
            string typeNamespace, Func<string, T> defaultValue)
        {
            if (dictionary.TryGetValue(typeName, out var type))
            {
                return (T)Activator.CreateInstance(type);
            }

            var resultingType = Type.GetType(typeNamespace + "." + typeName);
            if (resultingType != null)
            {
                return (T)Activator.CreateInstance(dictionary.GetOrAdd(typeName, resultingType));
            }

            return defaultValue(typeName);
        }
    }
}
