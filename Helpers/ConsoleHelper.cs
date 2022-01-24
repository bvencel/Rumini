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
                sb.Append("    ");
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
            Out(indent, $"Overall situation" +
                $"");
            indent++;

            if (game.CurrectSceneCard != null)
            {
                Out(indent, $"Current scene card {GetDeckStringS(game.CurrectSceneCard.Characters)}, value {game.CurrectSceneCard.PointValue}");
            }

            Out(indent, $"Score [min: {game.Players.Min(p => p.Scores.Sum())}] [max: {game.Players.Max(p => p.Scores.Sum())}] [average: {game.Players.Average(p => p.Scores.Sum()):0.##}]");

            // Players
            foreach (var player in game.Players)
            {
                indent--;

                Out(indent, $"Player #{player.PlayerNumber}");
                indent++;
                Out(indent, $"Deck {GetDeckString(player.DeckCharacterCards)}");
                Out(indent, $"Score {player.Scores.Sum()} {player.Scores.ToStringSerialized()}");
            }

            Console.WriteLine();
        }
    }
}