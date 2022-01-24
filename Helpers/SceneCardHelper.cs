using Rumini.Entities;

namespace Rumini.Helpers
{
    internal static class SceneCardHelper
    {
        public static bool MoveCards(List<SceneCard> sourceDeck, List<SceneCard> targetDeck, int nrCardsToMove)
        {
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

        public static bool MoveAllCards(List<SceneCard> sourceDeck, List<SceneCard> targetDeck)
        {
            return MoveCards(sourceDeck, targetDeck, sourceDeck.Count);
        }
    }
}