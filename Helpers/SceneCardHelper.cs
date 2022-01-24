using Rumini.Entities;
using Rumini.Enums;

namespace Rumini.Helpers
{
    internal static class SceneCardHelper
    {
        public static bool MoveAllCards(List<SceneCard> sourceDeck, List<SceneCard> targetDeck)
        {
            return MoveCards(sourceDeck, targetDeck, sourceDeck.Count);
        }

        public static bool MoveCards(List<SceneCard> sourceDeck, List<SceneCard> targetDeck, int nrCardsToMove)
        {
            if (nrCardsToMove == 0)
            {
                return true;
            }

            if (sourceDeck == null)
            {
                Console.WriteLine($"Source deck was null while moving {nrCardsToMove} scene cards");
                return false;
            }

            if (sourceDeck.Count < nrCardsToMove)
            {
                Console.WriteLine($"Source deck only contains {sourceDeck.Count} cards, not enough for moving {nrCardsToMove} scene cards");
                return false;
            }

            if (targetDeck == null)
            {
                Console.WriteLine($"Target deck was null while moving {nrCardsToMove} scene cards");
                return false;
            }

            List<SceneCard> cardsToMove = sourceDeck.Take(nrCardsToMove).ToList();
            cardsToMove.ForEach(card => sourceDeck.Remove(card));
            targetDeck.AddRange(cardsToMove);

            return true;
        }

        public static bool SceneCardContainsCharacter(SceneCard sceneCardToCheck, Character character)
        {
            return sceneCardToCheck.Characters.Any(c => c.CharacterOfCard == character);
        }
    }
}