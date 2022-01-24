using Rumini.Entities;
using Rumini.Helpers;

const int NrPlayers = 3;

int counter = 0;
double avgMin = 0;
double avgMax = 0;
double avg = 0;

while (counter < 100000)
{
    counter++;
    //Console.WriteLine($"Game #{counter}");

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

    if (counter == 1)
    {
        avg = game.Players.Average(s => s.Scores.Sum());
        avgMin = game.Players.Min(s => s.Scores.Sum());
        avgMax = game.Players.Max(s => s.Scores.Sum());
    }
    else
    {
        avg = ((avg * (counter - 1)) + game.Players.Average(s => s.Scores.Sum())) / counter;
        avgMin = ((avgMin * (counter - 1)) + game.Players.Min(s => s.Scores.Sum())) / counter;
        avgMax = ((avgMax * (counter - 1)) + game.Players.Max(s => s.Scores.Sum())) / counter;
    }
}

Console.WriteLine($"Score [Min: {avgMin:0.##}] [Average: {avg:0.##}] [Max: {avgMax:0.##}]");

// Run 2022-01-24 21:52: [Min: 47.65] [Average: 68.3] [Max: 89.17]