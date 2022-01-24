using Rumini.Entities;

namespace Rumini.Helpers
{
    internal static class CharacterCardHelper
    {
        public static bool MoveCards(List<CharacterCard> sourceDeck, List<CharacterCard> targetDeck, int nrCardsToMove)
        {
            if (sourceDeck == null)
            {
                Console.WriteLine($"Source deck was null while moving {nrCardsToMove} character cards");
                return false;
            }

            if (sourceDeck.Count < nrCardsToMove)
            {
                Console.WriteLine($"Source deck only contains {sourceDeck.Count} cards, not enough for moving {nrCardsToMove} character cards");
                return false;
            }

            if (targetDeck == null)
            {
                Console.WriteLine($"Target deck was null while moving {nrCardsToMove} character cards");
                return false;
            }

            List<CharacterCard> cardsToMove = sourceDeck.Take(nrCardsToMove).ToList();
            cardsToMove.ForEach(card => sourceDeck.Remove(card));
            targetDeck.AddRange(cardsToMove);

            return true;
        }
    }
}