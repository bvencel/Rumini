using Rumini.Enums;

namespace Rumini.Entities
{
    internal class SceneCard
    {
        public List<Character> Characters { get; set; } = new();
        public int PointValue
        {
            get; set;
        }
    }
}