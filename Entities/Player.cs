using Rumini.Enums;

namespace Rumini.Entities
{
    internal class Player
    {
        public int PlayerNumber = 0;

        public List<CharacterCard> DeckCharacterCards { get; set; } = new();

        public List<SceneCard> DeckSceneCards { get; set; } = new();

        public List<int> Scores { get; set; } = new();

        /// <summary>
        /// Determines if the player has a squid card and gives reference to it.
        /// </summary>
        /// <param name="squidCard"></param>
        /// <returns></returns>
        public bool HasSquidCard(out CharacterCard? squidCard)
        {
            CharacterCard? card = DeckCharacterCards.Where(c => c.CharacterOfCard == Character.Oriaspolip).FirstOrDefault();

            if (card == null)
            {
                squidCard = null;
                return false;
            }

            squidCard = card;
            return true;
        }

        /// <summary>
        /// The collection of cards that is put down for the <see cref="Game.CurrectSceneCard"/>.
        /// </summary>
        public List<CharacterCard> PlayedCharacterCards { get; set; } = new();
    }
}