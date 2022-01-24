using System.Diagnostics;

namespace Rumini.Entities
{
    [DebuggerDisplay("Round = {Round}")]
    internal class Game
    {
        public SceneCard? CurrectSceneCard
        {
            get
            {
                if (Round >= 1)
                {
                    return DeckSceneCards[Round - 1];
                }

                return null;
            }
        }

        public List<CharacterCard> DeckCaracterCards { get; set; } = new();

        public List<CharacterCard> DeckDiscardedCaracterCards { get; set; } = new();

        public List<SceneCard> DeckDiscardedSceneCards { get; set; } = new();

        public List<SceneCard> DeckSceneCards { get; set; } = new();

        public List<SceneCard> DeckSceneCardsOriginal { get; set; } = new();

        public List<Player> Players { get; set; } = new();

        public int Round { get; set; } = 0;
    }
}