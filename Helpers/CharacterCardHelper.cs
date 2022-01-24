using Rumini.Entities;
using Rumini.Enums;

namespace Rumini.Helpers
{
    internal static class CharacterCardHelper
    {
        public static int GetCharacterPointValue(Character character)
        {
            return character switch
            {
                Character.Rumini => 1,
                Character.Baliko => 1,
                Character.Feco => 2,
                Character.Kapitany => 3,
                Character.Sebestyen => 3,
                Character.Negro => 4,
                Character.Bandi => 5,
                Character.Johanna => 5,
                Character.Rozi => 6,
                _ => 1000,
            };
        }

        public static bool MoveAllCards(List<CharacterCard> sourceDeck, List<CharacterCard> targetDeck)
        {
            return MoveCards(sourceDeck, targetDeck, sourceDeck.Count);
        }

        public static bool MoveCards(List<CharacterCard> sourceDeck, List<CharacterCard> targetDeck, int nrCardsToMove)
        {
            if (sourceDeck == null)
            {
                Console.WriteLine($"Source deck was null while moving {nrCardsToMove} character cards");
                return false;
            }

            if (sourceDeck.Count < nrCardsToMove)
            {
                ////Console.WriteLine($"Source deck only contains {sourceDeck.Count} cards, not enough for moving {nrCardsToMove} character cards");
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

        public static bool MoveCardWithId(int cardIdToMove, List<CharacterCard> sourceDeck, List<CharacterCard> targetDeck)
        {
            if (sourceDeck == null)
            {
                Console.WriteLine("Source deck was null while moving a character card");
                return false;
            }

            if (targetDeck == null)
            {
                Console.WriteLine("Target deck was null while moving a character card");
                return false;
            }

            CharacterCard? card = sourceDeck.FirstOrDefault(c => c.Id == cardIdToMove);
            if (card == null)
            {
                return false;
            }

            sourceDeck.Remove(card);
            targetDeck.Add(card);

            return true;
        }
    }
}