using Rumini.Enums;

namespace Rumini.Entities
{
    internal class SceneCard : ICloneable
    {
        public List<Character> Characters { get; set; } = new();

        public int PointValue
        {
            get; set;
        }

        public object Clone()
        {
            SceneCard clone = new()
            {
                PointValue = PointValue,
            };

            foreach (Character item in Characters)
            {
                clone.Characters.Add(item);
            }

            return clone;
        }
    }
}