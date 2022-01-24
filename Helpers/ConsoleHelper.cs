using Rumini.Entities;
using Rumini.Enums;
using Rumini.ExtensionMethods;

using System.Text;

namespace Rumini.Helpers
{
    internal static class ConsoleHelper
    {
        public static string GetDeckString(List<CharacterCard> characterCards)
        {
            StringBuilder sb = new("[");
            bool first = true;

            foreach (CharacterCard character in characterCards)
            {
                if (!first)
                {
                    sb.Append(", ");
                }

                sb.Append(Enum.GetName(typeof(Character), character.CharacterOfCard));
                first = false;
            }

            sb.Append(']');

            return sb.ToString();
        }

        public static string GetDeckStringS(List<SceneCardCharacter> characterCards)
        {
            StringBuilder sb = new("[");
            bool first = true;

            foreach (SceneCardCharacter character in characterCards)
            {
                if (!first)
                {
                    sb.Append(", ");
                }

                sb.Append(Enum.GetName(typeof(Character), character.CharacterOfCard));
                first = false;
            }

            sb.Append(']');

            return sb.ToString();
        }

        public static string GetIndent(int indentLevel)
        {
            StringBuilder sb = new();
            for (int i = 0; i < indentLevel; i++)
            {
                sb.Append("  ");
            }

            return sb.ToString();
        }

        public static void Out(int indentLevel, string message)
        {
            Console.WriteLine($"{GetIndent(indentLevel)}{message}");
        }

        public static void PrintGame(Game game)
        {
            int indent = 1;

            Out(indent, $"Round {game.Round}");

            indent++;

            // Game parameters
            Out(indent, $"Game stuff");
            indent++;

            if (game.CurrectSceneCard != null)
            {
                Out(indent, $"Current scene card {GetDeckStringS(game.CurrectSceneCard.Characters)}");
            }

            // Players
            foreach (var player in game.Players)
            {
                indent--;

                Out(indent, $"Player #{player.PlayerNumber}");
                indent++;
                Out(indent, $"Deck {GetDeckString(player.DeckCharacterCards)}");
                Out(indent, $"Scores {player.Scores.ToStringSerialized()}");
            }

            double avgScoreOfPlayers = game.Players.Average(p => p.Scores.Sum());

            Out(indent, $"Average score: {avgScoreOfPlayers:0.##}");

            Console.WriteLine();
        }
    }
}