using System.Diagnostics;

namespace Rumini.Entities
{
    [DebuggerDisplay("Round = {Round}")]
    internal class Game
    {
        public List<Player> players = new();

        public int Round { get; set; } = 0;

        
        public List<CharacterCard> OriginalDeckShuffled { get; set; } = new List<CharacterCard>();


    }
}