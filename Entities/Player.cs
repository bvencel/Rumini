namespace Rumini.Entities
{
    internal class Player
    {
        public List<CharacterCard> CardsInHand { get; set; } = new List<CharacterCard> { };

        public List<SceneCard> SceneCardsInHand { get; set; } = new List<SceneCard> { };
    }
}