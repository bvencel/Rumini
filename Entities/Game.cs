namespace Rumini.Entities
{
    internal class Game
    {
        public List<Player> players = new();

        public int Round { get; set; } = 0;
    }
}