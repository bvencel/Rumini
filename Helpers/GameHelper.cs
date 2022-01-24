using Rumini.Constants;
using Rumini.Entities;
using Rumini.Enums;
using Rumini.ExtensionMethods;

namespace Rumini.Helpers
{
    internal static class GameHelper
    {
        private const int MaxNrPlayers = 6;
        private const int MinNrPlayers = 2;

        /// <summary>
        /// Player gets punished for the cards remaining in its hand.
        /// </summary>
        /// <param name="game"></param>
        public static void CalculateEndScores(Game game)
        {
            foreach (Player player in game.Players)
            {
                int multiplier = -3;
                int valuesOfCardsInPlayerHand = player.DeckCharacterCards.Sum(c => c.PointValue);

                player.Scores.Add(valuesOfCardsInPlayerHand * multiplier);
            }
        }

        public static void CalculateScores(Game game)
        {
            foreach (Player player in game.Players)
            {
                int multiplier = GetMultiplierBasedOnRound(game.Round);
                int sceneCardPoints = game.CurrectSceneCard?.PointValue ?? 0;

                int cardValuesOfPlayer = player.PlayedCharacterCards.Sum(c => c.PointValue);

                if (cardValuesOfPlayer == 0)
                {
                    // Player passed
                    player.Scores.Add(0);
                }
                else
                {
                    player.Scores.Add((sceneCardPoints + cardValuesOfPlayer) * multiplier);
                }
            }
        }

        public static bool PlayersMoveWithCharacterCards(Game game)
        {
            // Put down match
            foreach (Player player in game.Players)
            {
                // ToDo: replace with AI

                // Play matching cards
                bool cardPlayed = false;
                List<CharacterCard> userCharacterCardsCopy = player.DeckCharacterCards.Clone().ToList();

                foreach (CharacterCard card in userCharacterCardsCopy)
                {
                    if (
                        game.CurrectSceneCard is not null &&
                        SceneCardHelper.SceneCardContainsCharacter(game.CurrectSceneCard, card.CharacterOfCard) &&
                        !PlayerAlreadyPlayedCharacter(player.PlayedCharacterCards, card.CharacterOfCard))
                    {
                        CharacterCardHelper.MoveCardWithId(card.Id, player.DeckCharacterCards, player.PlayedCharacterCards);
                        cardPlayed = true;
                    }
                }

                // Use the squid when the reqards are worth it
                if (game.Round > 4)
                {
                    bool hasSquidCard = player.HasSquidCard(out CharacterCard? squidCard);

                    if (hasSquidCard && squidCard is not null && game.CurrectSceneCard is not null)
                    {
                        // Player has a squid card
                        // Find the largest card number it can be replaced with
                        // Largest number card is at the end of the collection
                        for (int i = game.CurrectSceneCard.Characters.Count - 1; i >= 0; i--)
                        {
                            if (player.PlayedCharacterCards.Any(p => p.CharacterOfCard == game.CurrectSceneCard.Characters[i].CharacterOfCard))
                            {
                                // Card already played
                                continue;
                            }

                            squidCard.PlayedAsCharacter = game.CurrectSceneCard.Characters[i].CharacterOfCard;

                            // Play squid as the found card
                            CharacterCardHelper.MoveCardWithId(squidCard.Id, player.DeckCharacterCards, player.PlayedCharacterCards);
                            cardPlayed = true;

                            continue;
                        }
                    }
                }

                // Pass
                if (!cardPlayed)
                {
                    switch (game.Round)
                    {
                        case 1:
                        case 2:
                            // Pick up two cards
                            CharacterCardHelper.MoveCards(game.DeckCaracterCards, player.DeckCharacterCards, 2);
                            break;

                        case 3:
                        case 4:
                            // Pick up 1 card
                            CharacterCardHelper.MoveCards(game.DeckCaracterCards, player.DeckCharacterCards, 1);
                            break;

                        case 7:
                            // A card could be thrown away, but not implemented yet
                            break;

                        case 8:
                            // If player still has cards
                            if (player.DeckCharacterCards.Count > 0)
                            {
                                // No card was played, throw away the biggest one
                                bool hasSquidCard = player.HasSquidCard(out CharacterCard? squidCard);

                                if (hasSquidCard && squidCard is not null && game.CurrectSceneCard is not null)
                                {
                                    CharacterCardHelper.MoveCardWithId(squidCard.Id, player.DeckCharacterCards, game.DeckDiscardedCaracterCards);
                                }
                                else
                                {
                                    // Not squid card
                                    CharacterCard? maxValuedCard = player.DeckCharacterCards.OrderByDescending(c => c.PointValue).FirstOrDefault();

                                    if (maxValuedCard != null)
                                    {
                                        CharacterCardHelper.MoveCardWithId(maxValuedCard.Id, player.DeckCharacterCards, game.DeckDiscardedCaracterCards);
                                    }
                                }
                            }

                            break;

                        default:
                        case 5:
                        case 6:
                            // Do nothing
                            break;
                    }
                }
            }

            return true;
        }

        public static bool PlayersThrowAwayPlayedCards(Game game)
        {
            foreach (Player player in game.Players)
            {
                CharacterCardHelper.MoveAllCards(player.PlayedCharacterCards, game.DeckDiscardedCaracterCards);
            }

            return true;
        }

        public static void PlayGame(int nrPlayers, out Game game)
        {
            game = new Game();

            _ = StartGame(nrPlayers, game);

            for (int i = 0; i < 8; i++)
            {
                game.Round = i + 1;

                _ = PlayersMoveWithCharacterCards(game);
                CalculateScores(game);
                _ = PlayersThrowAwayPlayedCards(game);
            }
        }

        public static bool StartGame(int nrPlayers, Game game)
        {
            game.DeckCaracterCards = DeckDefinitions.CharacterCards.CloneAndShuffle().ToList();
            game.DeckSceneCardsOriginal = DeckDefinitions.SceneCards.CloneAndShuffle().ToList();
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

        private static int GetMultiplierBasedOnRound(int round)
        {
            return round switch
            {
                3 or 4 => 2,
                5 or 6 => 3,
                7 or 8 => 4,
                _ => 1,
            };
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

        private static bool PlayerAlreadyPlayedCharacter(List<CharacterCard> playedCharacterCards, Character character)
        {
            return playedCharacterCards.Any(c => c.CharacterOfCard == character);
        }

        private static bool PlayersSwitchCharacterCards(Game game)
        {
            const int NrMaxCharacterCardsToReplace = 3;

            foreach (Player player in game.Players)
            {
                // Discard up-to 3 cards
                int nrCardsSwitched = new Random().Next(0, NrMaxCharacterCardsToReplace + 1);

                // ToDo: replace decision with AI
                CharacterCardHelper.MoveCards(player.DeckCharacterCards, game.DeckDiscardedCaracterCards, nrCardsSwitched);

                // Replenish what was discarded
                CharacterCardHelper.MoveCards(game.DeckCaracterCards, player.DeckCharacterCards, nrCardsSwitched);
            }

            return true;
        }
    }
}