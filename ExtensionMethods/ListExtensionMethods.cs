namespace Rumini.ExtensionMethods
{
    internal static class ListExtensionMethods
    {
        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }

        public static IList<T> CloneAndShuffle<T>(this IList<T> source) where T : ICloneable
        {
            // Create a copy of the original list
            IList<T> clone = source.Clone();
            clone.Shuffle();

            return clone;
        }

        public static void Shuffle<T>(this IList<T> source)
        {
            Random rnd = new();
            int n = source.Count;

            // Fisher Yates Shuffle in place
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = source[k];
                source[k] = source[n];
                source[n] = value;
            }
        }
    }
}