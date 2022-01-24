using Rumini.Entities;
using Rumini.Enums;
using Rumini.ExtensionMethods;

namespace Rumini.Helpers
{
    internal static class GameHelper
    {
        private const int MaxNrPlayers = 6;
        private const int MinNrPlayers = 2;

        public static List<CharacterCard> CharacterCards => new()
        {
            new CharacterCard() { Id = 0, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 1, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 2, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 3, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 4, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 5, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 6, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 7, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 8, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 9, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 10, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 11, CharacterOfCard = Character.Rumini },

            new CharacterCard() { Id = 12, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 13, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 14, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 15, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 16, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 17, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 18, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 19, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 20, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 21, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 22, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 23, CharacterOfCard = Character.Baliko },

            new CharacterCard() { Id = 24, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 25, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 26, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 27, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 28, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 29, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 30, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 31, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 32, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 33, CharacterOfCard = Character.Feco },

            new CharacterCard() { Id = 34, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { Id = 35, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { Id = 36, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { Id = 37, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { Id = 38, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { Id = 39, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { Id = 40, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { Id = 41, CharacterOfCard = Character.Kapitany },

            new CharacterCard() { Id = 42, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { Id = 43, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { Id = 44, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { Id = 45, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { Id = 46, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { Id = 47, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { Id = 48, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { Id = 49, CharacterOfCard = Character.Sebestyen },

            new CharacterCard() { Id = 50, CharacterOfCard = Character.Negro },
            new CharacterCard() { Id = 51, CharacterOfCard = Character.Negro },
            new CharacterCard() { Id = 52, CharacterOfCard = Character.Negro },
            new CharacterCard() { Id = 53, CharacterOfCard = Character.Negro },
            new CharacterCard() { Id = 54, CharacterOfCard = Character.Negro },
            new CharacterCard() { Id = 55, CharacterOfCard = Character.Negro },

            new CharacterCard() { Id = 56, CharacterOfCard = Character.Bandi },
            new CharacterCard() { Id = 57, CharacterOfCard = Character.Bandi },
            new CharacterCard() { Id = 58, CharacterOfCard = Character.Bandi },
            new CharacterCard() { Id = 59, CharacterOfCard = Character.Bandi },

            new CharacterCard() { Id = 60, CharacterOfCard = Character.Johanna },
            new CharacterCard() { Id = 61, CharacterOfCard = Character.Johanna },
            new CharacterCard() { Id = 62, CharacterOfCard = Character.Johanna },
            new CharacterCard() { Id = 63, CharacterOfCard = Character.Johanna },

            new CharacterCard() { Id = 64, CharacterOfCard = Character.Rozi },
            new CharacterCard() { Id = 65, CharacterOfCard = Character.Rozi },

            new CharacterCard() { Id = 66, CharacterOfCard = Character.Oriaspolip },
            new CharacterCard() { Id = 67, CharacterOfCard = Character.Oriaspolip },
        };

        public static List<SceneCard> SceneCards => new()
        {
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Feco, Character.Kapitany, Character.Sebestyen, Character.Negro } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Feco, Character.Kapitany, Character.Sebestyen, Character.Negro } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Kapitany, Character.Sebestyen, Character.Negro, Character.Bandi } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Feco, Character.Kapitany, Character.Rozi } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Feco, Character.Sebestyen, Character.Johanna } },
            new SceneCard() { Characters = new List<Character> { Character.Baliko, Character.Feco, Character.Kapitany, Character.Sebestyen } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Feco, Character.Kapitany } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Negro, Character.Bandi } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Feco } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Feco } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Feco } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Negro } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Sebestyen } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Feco, Character.Johanna } },
            new SceneCard() { Characters = new List<Character> { Character.Baliko, Character.Feco } },
            new SceneCard() { Characters = new List<Character> { Character.Baliko, Character.Feco } },
            new SceneCard() { Characters = new List<Character> { Character.Baliko, Character.Sebestyen } },
            new SceneCard() { Characters = new List<Character> { Character.Feco, Character.Johanna } },
            new SceneCard() { Characters = new List<Character> { Character.Feco, Character.Kapitany } },
            new SceneCard() { Characters = new List<Character> { Character.Kapitany, Character.Sebestyen } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Baliko } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Baliko } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Kapitany } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Negro } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini, Character.Rozi } },
            new SceneCard() { Characters = new List<Character> { Character.Baliko } },
            new SceneCard() { Characters = new List<Character> { Character.Bandi } },
            new SceneCard() { Characters = new List<Character> { Character.Feco } },
            new SceneCard() { Characters = new List<Character> { Character.Feco } },
            new SceneCard() { Characters = new List<Character> { Character.Negro } },
            new SceneCard() { Characters = new List<Character> { Character.Rumini } },
            new SceneCard() { Characters = new List<Character> { Character.Sebestyen } },
        };

        public static bool PlayGame(int nrPlayers, out Game game)
        {
            game = new Game();

            if (nrPlayers < MinNrPlayers || nrPlayers > MaxNrPlayers)
            {
                Console.WriteLine($"{nrPlayers} is not a valid player count. The game supports {MinNrPlayers} to {MaxNrPlayers} players.");
                return false;
            }

            bool success = StartGame(nrPlayers, game);

            success &= MidGame(game);

            return success;
        }

        private static void AddPlayers(int nrPlayers, Game game)
        {
            // Add players
            for (int i = 0; i < nrPlayers; i++)
            {
                game.Players.Add(new Player()
                {
                    PlayerNumber = i,
                });
            }
        }

        private static bool CompleteSceneCardsToEight(Game game)
        {
            const int NrInitialSceneCardsNeeded = 8;

            SceneCardHelper.MoveCards(
                game.DeckSceneCardsOriginal,
                game.DeckSceneCards,
                NrInitialSceneCardsNeeded - game.DeckSceneCards.Count);

            return true;
        }

        private static bool DiscardOneSceneCard(Game game)
        {
            foreach (Player player in game.Players)
            {
                // ToDo: replace shuffle with AI
                player.DeckSceneCards.Shuffle();
                SceneCardHelper.MoveCards(player.DeckSceneCards, game.DeckDiscardedSceneCards, 1);
            }

            return true;
        }

        private static bool GatherRemainingSceneCards(Game game)
        {
            foreach (Player player in game.Players)
            {
                SceneCardHelper.MoveAllCards(player.DeckSceneCards, game.DeckSceneCards);
            }

            game.DeckSceneCards.Shuffle();

            return true;
        }

        private static bool InitialDealCharacterCards(Game game)
        {
            const int NrCharacterCardsInitiallyDealt = 6;

            foreach (Player player in game.Players)
            {
                CharacterCardHelper.MoveCards(game.DeckCaracterCards, player.DeckCharacterCards, NrCharacterCardsInitiallyDealt);
            }

            return true;
        }

        private static bool InitialDealSceneCards(Game game)
        {
            // 2-4 players → 4 cards, 5-6 → 3 cards
            int nrSceneCardsToDeal = game.Players.Count <= 4 ? 4 : 3;

            foreach (Player player in game.Players)
            {
                SceneCardHelper.MoveCards(game.DeckSceneCardsOriginal, player.DeckSceneCards, nrSceneCardsToDeal);
            }

            return true;
        }

        private static bool MidGame(Game game)
        {
            int round = 0;
            bool success = true;

            foreach (SceneCard sceneCard in game.DeckSceneCards)
            {
                round++;

                game.Round = round;

                success &= PlayersMoveWithCharacterCards(game);
                //  HandleGiantSquid()
                //  HandlePass()
                // CalculateScores()
            }

            return true;
        }

        private static bool MoveSceneCardsToNextPlayer(Game game)
        {
            List<SceneCard> tempSceneCards = new();

            // Move cards of first player to a temp deck
            SceneCardHelper.MoveAllCards(
                game.Players[0].DeckSceneCards,
                tempSceneCards);

            // Do not include first player
            for (int i = 1; i < game.Players.Count; i++)
            {
                // Give cards to previous player
                SceneCardHelper.MoveAllCards(
                    game.Players[i].DeckSceneCards,
                    game.Players[i - 1].DeckSceneCards);
            }

            // Give original deck of player 0 to the last one
            SceneCardHelper.MoveAllCards(
                tempSceneCards,
                game.Players[^1].DeckSceneCards);

            return true;
        }

        private static bool PlayersMoveWithCharacterCards(Game game)
        {
            // Put down match
            foreach (Player player in game.Players)
            {
                // ToDo: replace with AI

                List<CharacterCard> userCharacterCardsCopy = player.DeckCharacterCards.Clone().ToList();

                foreach (CharacterCard card in userCharacterCardsCopy)
                {
                    if (
                        game.CurrectSceneCard.Characters.Contains(card.CharacterOfCard) &&
                        !player.PlayedCharacterCards.Contains(card))
                    {
                        CharacterCardHelper.MoveCardWithId(card.Id, player.DeckCharacterCards, player.PlayedCharacterCards);
                    }
                }

                // Use the squid when the reqards are worth it
                if (game.Round > 4)
                {
                    bool hasSquidCard = player.HasSquidCard(out CharacterCard? squidCard);

                    if (hasSquidCard)
                    {
                        // Player has a squid card

                        // Find the largest card number it can be replaced with
                    }
                }
            }

            return true;

            //  HandleGiantSquid()
            //  HandlePass()
        }

        private static bool PlayersSwitchCharacterCards(Game game)
        {
            const int NrMaxCharacterCardsToReplace = 3;

            foreach (Player player in game.Players)
            {
                // Discard up-to 3 cards
                int nrCardsSwitched = new Random().Next(0, NrMaxCharacterCardsToReplace + 1);

                // ToDo: replace shuffle with AI
                player.DeckCharacterCards.Shuffle();
                CharacterCardHelper.MoveCards(player.DeckCharacterCards, game.DeckDiscardedCaracterCards, nrCardsSwitched);

                // Replenish what was discarded
                CharacterCardHelper.MoveCards(game.DeckCaracterCards, player.DeckCharacterCards, nrCardsSwitched);
            }

            return true;
        }

        private static bool StartGame(int nrPlayers, Game game)
        {
            game.DeckCaracterCards = CharacterCards.CloneAndShuffle().ToList();
            game.DeckSceneCardsOriginal = SceneCards.CloneAndShuffle().ToList();
            game.Round = 0;

            AddPlayers(nrPlayers, game);

            if (!InitialDealCharacterCards(game))
            {
                return false;
            }

            if (!PlayersSwitchCharacterCards(game))
            {
                return false;
            }

            if (!InitialDealSceneCards(game))
            {
                return false;
            }

            if (!DiscardOneSceneCard(game))
            {
                return false;
            }

            if (!MoveSceneCardsToNextPlayer(game))
            {
                return false;
            }

            if (!DiscardOneSceneCard(game))
            {
                return false;
            }

            if (!GatherRemainingSceneCards(game))
            {
                return false;
            }

            if (!CompleteSceneCardsToEight(game))
            {
                return false;
            }

            return true;
        }
    }
}