namespace Rumini.Entities
{
    internal class Player
    {
        public int PlayerNumber = 0;

        public List<CharacterCard> DeckCharacterCards { get; set; } = new();

        public List<SceneCard> DeckSceneCards { get; set; } = new();

        public List<int> Scores { get; set; } = new();
    }
}