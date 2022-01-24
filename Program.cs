using Rumini.Entities;
using Rumini.Helpers;

const int NrPlayers = 3;

int counter = 0;

while (true)
{
    counter++;
    Console.WriteLine($"Game #{counter}");

    Game game = new Game();

    _ = GameHelper.StartGame(NrPlayers, game);
    ConsoleHelper.PrintGame(game);

    for (int i = 0; i < 8; i++)
    {
        game.Round = i + 1;

        _ = GameHelper.PlayersMoveWithCharacterCards(game);
        GameHelper.CalculateScores(game);
        _ = GameHelper.PlayersThrowAwayPlayedCards(game);
        ConsoleHelper.PrintGame(game);
    }

    Console.ReadLine();
}