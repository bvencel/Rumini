﻿using Rumini.Entities;
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
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Rumini },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Rumini },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Rumini },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Rumini },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Rumini },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Rumini },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Rumini },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Rumini },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Rumini },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Rumini },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Rumini },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Rumini },

            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Baliko },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Baliko },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Baliko },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Baliko },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Baliko },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Baliko },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Baliko },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Baliko },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Baliko },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Baliko },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Baliko },
            new CharacterCard() { PointValue = 1, CharacterOfCard = Character.Baliko },

            new CharacterCard() { PointValue = 2, CharacterOfCard = Character.Feco },
            new CharacterCard() { PointValue = 2, CharacterOfCard = Character.Feco },
            new CharacterCard() { PointValue = 2, CharacterOfCard = Character.Feco },
            new CharacterCard() { PointValue = 2, CharacterOfCard = Character.Feco },
            new CharacterCard() { PointValue = 2, CharacterOfCard = Character.Feco },
            new CharacterCard() { PointValue = 2, CharacterOfCard = Character.Feco },
            new CharacterCard() { PointValue = 2, CharacterOfCard = Character.Feco },
            new CharacterCard() { PointValue = 2, CharacterOfCard = Character.Feco },
            new CharacterCard() { PointValue = 2, CharacterOfCard = Character.Feco },
            new CharacterCard() { PointValue = 2, CharacterOfCard = Character.Feco },

            new CharacterCard() { PointValue = 3, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { PointValue = 3, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { PointValue = 3, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { PointValue = 3, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { PointValue = 3, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { PointValue = 3, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { PointValue = 3, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { PointValue = 3, CharacterOfCard = Character.Kapitany },

            new CharacterCard() { PointValue = 3, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { PointValue = 3, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { PointValue = 3, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { PointValue = 3, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { PointValue = 3, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { PointValue = 3, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { PointValue = 3, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { PointValue = 3, CharacterOfCard = Character.Sebestyen },

            new CharacterCard() { PointValue = 4, CharacterOfCard = Character.Negro },
            new CharacterCard() { PointValue = 4, CharacterOfCard = Character.Negro },
            new CharacterCard() { PointValue = 4, CharacterOfCard = Character.Negro },
            new CharacterCard() { PointValue = 4, CharacterOfCard = Character.Negro },
            new CharacterCard() { PointValue = 4, CharacterOfCard = Character.Negro },
            new CharacterCard() { PointValue = 4, CharacterOfCard = Character.Negro },

            new CharacterCard() { PointValue = 5, CharacterOfCard = Character.Bandi },
            new CharacterCard() { PointValue = 5, CharacterOfCard = Character.Bandi },
            new CharacterCard() { PointValue = 5, CharacterOfCard = Character.Bandi },
            new CharacterCard() { PointValue = 5, CharacterOfCard = Character.Bandi },

            new CharacterCard() { PointValue = 5, CharacterOfCard = Character.Johanna },
            new CharacterCard() { PointValue = 5, CharacterOfCard = Character.Johanna },
            new CharacterCard() { PointValue = 5, CharacterOfCard = Character.Johanna },
            new CharacterCard() { PointValue = 5, CharacterOfCard = Character.Johanna },

            new CharacterCard() { PointValue = 6, CharacterOfCard = Character.Rozi },
            new CharacterCard() { PointValue = 6, CharacterOfCard = Character.Rozi },

            new CharacterCard() { PointValue = 10000, CharacterOfCard = Character.Oriaspolip },
            new CharacterCard() { PointValue = 10000, CharacterOfCard = Character.Oriaspolip },
        };

        public static List<SceneCard> SceneCards => new()
        {
            new SceneCard() { PointValue = 2, Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Feco, Character.Kapitany, Character.Sebestyen, Character.Negro } },
            new SceneCard() { PointValue = 2, Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Feco, Character.Kapitany, Character.Sebestyen, Character.Negro } },
            new SceneCard() { PointValue = 2, Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Kapitany, Character.Sebestyen, Character.Negro, Character.Bandi } },
            new SceneCard() { PointValue = 3, Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Feco, Character.Kapitany, Character.Rozi } },
            new SceneCard() { PointValue = 3, Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Feco, Character.Sebestyen, Character.Johanna } },
            new SceneCard() { PointValue = 4, Characters = new List<Character> { Character.Baliko, Character.Feco, Character.Kapitany, Character.Sebestyen } },
            new SceneCard() { PointValue = 4, Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Feco, Character.Kapitany } },
            new SceneCard() { PointValue = 4, Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Negro, Character.Bandi } },
            new SceneCard() { PointValue = 5, Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Feco } },
            new SceneCard() { PointValue = 5, Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Feco } },
            new SceneCard() { PointValue = 5, Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Feco } },
            new SceneCard() { PointValue = 5, Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Negro } },
            new SceneCard() { PointValue = 5, Characters = new List<Character> { Character.Rumini, Character.Baliko, Character.Sebestyen } },
            new SceneCard() { PointValue = 5, Characters = new List<Character> { Character.Rumini, Character.Feco, Character.Johanna } },
            new SceneCard() { PointValue = 6, Characters = new List<Character> { Character.Baliko, Character.Feco } },
            new SceneCard() { PointValue = 6, Characters = new List<Character> { Character.Baliko, Character.Feco } },
            new SceneCard() { PointValue = 6, Characters = new List<Character> { Character.Baliko, Character.Sebestyen } },
            new SceneCard() { PointValue = 6, Characters = new List<Character> { Character.Feco, Character.Johanna } },
            new SceneCard() { PointValue = 6, Characters = new List<Character> { Character.Feco, Character.Kapitany } },
            new SceneCard() { PointValue = 6, Characters = new List<Character> { Character.Kapitany, Character.Sebestyen } },
            new SceneCard() { PointValue = 6, Characters = new List<Character> { Character.Rumini, Character.Baliko } },
            new SceneCard() { PointValue = 6, Characters = new List<Character> { Character.Rumini, Character.Baliko } },
            new SceneCard() { PointValue = 6, Characters = new List<Character> { Character.Rumini, Character.Kapitany } },
            new SceneCard() { PointValue = 6, Characters = new List<Character> { Character.Rumini, Character.Negro } },
            new SceneCard() { PointValue = 6, Characters = new List<Character> { Character.Rumini, Character.Rozi } },
            new SceneCard() { PointValue = 8, Characters = new List<Character> { Character.Baliko } },
            new SceneCard() { PointValue = 8, Characters = new List<Character> { Character.Bandi } },
            new SceneCard() { PointValue = 8, Characters = new List<Character> { Character.Feco } },
            new SceneCard() { PointValue = 8, Characters = new List<Character> { Character.Feco } },
            new SceneCard() { PointValue = 8, Characters = new List<Character> { Character.Negro } },
            new SceneCard() { PointValue = 8, Characters = new List<Character> { Character.Rumini } },
            new SceneCard() { PointValue = 8, Characters = new List<Character> { Character.Sebestyen } },
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