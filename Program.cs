using Rumini.Entities;
using Rumini.Helpers;

const int NrPlayers = 3;

int counter = 0;

while (true)
{
    counter++;
    Console.WriteLine($"Game #{counter}");

    Game game = new();

    _ = GameHelper.StartGame(NrPlayers, game);
    //ConsoleHelper.PrintGame(game);

    for (int i = 1; i <= 8; i++)
    {
        game.Round = i;

        _ = GameHelper.PlayersMoveWithCharacterCards(game);
        GameHelper.CalculateScores(game);
        _ = GameHelper.PlayersThrowAwayPlayedCards(game);

        // Last round
        if (i == 8)
        {
            GameHelper.CalculateEndScores(game);
        }

        //ConsoleHelper.PrintGame(game);
    }

    Console.ReadLine();
}