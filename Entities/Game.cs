using System.Diagnostics;

namespace Rumini.Entities
{
    [DebuggerDisplay("Round = {Round}")]
    internal class Game
    {
        public List<CharacterCard> DeckCaracterCards { get; set; } = new();

        public List<CharacterCard> DeckDiscardedCaracterCards { get; set; } = new();

        public List<SceneCard> DeckDiscardedSceneCards { get; set; } = new();

        public List<SceneCard> DeckSceneCards { get; set; } = new();

        public List<SceneCard> DeckSceneCardsOriginal { get; set; } = new();

        public List<Player> Players => new();

        public int Round { get; set; } = 0;
    }
}