using Newtonsoft.Json;

namespace Rumini.ExtensionMethods
{
    internal static class ObjectExtensionMethods
    {
        public static string ToStringSerialized(this object source)
        {
            return JsonConvert.SerializeObject(source, Formatting.None);
        }
    }
}