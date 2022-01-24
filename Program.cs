using Rumini.Entities;
using Rumini.ExtensionMethods;
using Rumini.Helpers;

const int MaxPlayers = 6;

PlayerStrategy strategy = new()
{
    AlsoThrowAwayCardInTurnBeforeLast = true,
    DelayInvestingCards = 2,
    DoNotThrowAwayCards = false,
    InvestingCardsLimit = 3,
    ThrowAwayCheapCards = false,
    ThrowAwayCheapSceneCards = false,
    ThrowAwayDuplicates = false,
    ThrowAwayExpensiveCards = true,
    ThrowAwayExpensiveSceneCards = true,
};

ConsoleHelper.Out(0, $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}: Strategy {strategy.ToStringSerialized()}");

for (int playerCounter = 2; playerCounter <= MaxPlayers; playerCounter++)
{
    int counter = 0;
    double avgMin = 0;
    double avgMax = 0;
    double avg = 0;

    while (counter < 50000)
    {
        counter++;

        Game game = new();

        _ = GameHelper.StartGame(
            playerCounter,
            game,
            strategy);

        for (int i = 1; i <= 8; i++)
        {
            game.Round = i;

            _ = GameHelper.PlayersHandleCharacterCards(game);
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

    ConsoleHelper.Out(1, $"{playerCounter} player scores: [Min: {avgMin:0.0}] [Average: {avg:0.0}] [Max: {avgMax:0.0}]");
}

/*
2022-01-24 22:29: Strategy {"DelayInvestingCards":false,"LimitInvestingCardsToOne":false,"ThrowAwayCheapCards":false,"ThrowAwayDuplicates":false,"ThrowAwayExpensiveCards":false}
    2 player scores: [Min: 54.51] [Average: 68.40] [Max: 82.29]
    3 player scores: [Min: 47.62] [Average: 68.26] [Max: 89.19]
    4 player scores: [Min: 43.31] [Average: 68.37] [Max: 94.04]
    5 player scores: [Min: 39.93] [Average: 68.15] [Max: 97.14]
    6 player scores: [Min: 37.50] [Average: 68.24] [Max: 99.83]

2022-01-24 22:36: Strategy {"DelayInvestingCards":1,"LimitInvestingCardsToOne":false,"ThrowAwayCheapCards":false,"ThrowAwayCheapSceneCards":false,"ThrowAwayDuplicates":false,"ThrowAwayExpensiveCards":false,"ThrowAwayExpensiveSceneCards":false}
    2 player scores: [Min: 63.4] [Average: 78.6] [Max: 93.7]
    3 player scores: [Min: 55.7] [Average: 78.5] [Max: 101.0]
    4 player scores: [Min: 50.7] [Average: 78.6] [Max: 105.8]
    5 player scores: [Min: 46.8] [Average: 78.5] [Max: 109.2]
    6 player scores: [Min: 43.9] [Average: 78.5] [Max: 112.0]

2022-01-24 22:38: Strategy {"DelayInvestingCards":2,"LimitInvestingCardsToOne":false,"ThrowAwayCheapCards":false,"ThrowAwayCheapSceneCards":false,"ThrowAwayDuplicates":false,"ThrowAwayExpensiveCards":false,"ThrowAwayExpensiveSceneCards":false}
    2 player scores: [Min: 74.7] [Average: 92.0] [Max: 109.3]
    3 player scores: [Min: 65.5] [Average: 92.0] [Max: 117.6]
    4 player scores: [Min: 59.5] [Average: 91.9] [Max: 122.8]
    5 player scores: [Min: 55.2] [Average: 91.9] [Max: 126.4]
    6 player scores: [Min: 49.9] [Average: 89.8] [Max: 127.4]

2022-01-24 22:39: Strategy {"DelayInvestingCards":3,"LimitInvestingCardsToOne":false,"ThrowAwayCheapCards":false,"ThrowAwayCheapSceneCards":false,"ThrowAwayDuplicates":false,"ThrowAwayExpensiveCards":false,"ThrowAwayExpensiveSceneCards":false}
    2 player scores: [Min: 69.0] [Average: 87.3] [Max: 105.6]
    3 player scores: [Min: 59.7] [Average: 87.6] [Max: 114.7]
    4 player scores: [Min: 53.5] [Average: 87.6] [Max: 120.0]
    5 player scores: [Min: 48.6] [Average: 87.5] [Max: 123.8]
    6 player scores: [Min: 42.4] [Average: 83.6] [Max: 122.2]

2022-01-24 22:44: Strategy {"DelayInvestingCards":2,"InvestingCardsLimit":2,"ThrowAwayCheapCards":false,"ThrowAwayCheapSceneCards":false,"ThrowAwayDuplicates":false,"ThrowAwayExpensiveCards":false,"ThrowAwayExpensiveSceneCards":false}
    2 player scores: [Min: 74.1] [Average: 92.4] [Max: 110.7]
    3 player scores: [Min: 64.7] [Average: 92.7] [Max: 120.0]
    4 player scores: [Min: 58.3] [Average: 92.5] [Max: 125.2]
    5 player scores: [Min: 53.5] [Average: 92.4] [Max: 129.1]
    6 player scores: [Min: 48.8] [Average: 91.0] [Max: 130.7]

2022-01-24 22:45: Strategy {"DelayInvestingCards":2,"InvestingCardsLimit":1,"ThrowAwayCheapCards":false,"ThrowAwayCheapSceneCards":false,"ThrowAwayDuplicates":false,"ThrowAwayExpensiveCards":false,"ThrowAwayExpensiveSceneCards":false}
    2 player scores: [Min: 60.0] [Average: 76.8] [Max: 93.6]
    3 player scores: [Min: 50.9] [Average: 76.9] [Max: 101.8]
    4 player scores: [Min: 44.9] [Average: 77.0] [Max: 106.7]
    5 player scores: [Min: 40.5] [Average: 77.0] [Max: 109.8]
    6 player scores: [Min: 37.7] [Average: 77.7] [Max: 113.3]

2022-01-24 22:45: Strategy {"DelayInvestingCards":2,"InvestingCardsLimit":3,"ThrowAwayCheapCards":false,"ThrowAwayCheapSceneCards":false,"ThrowAwayDuplicates":false,"ThrowAwayExpensiveCards":false,"ThrowAwayExpensiveSceneCards":false}
    2 player scores: [Min: 74.9] [Average: 92.7] [Max: 110.5]
    3 player scores: [Min: 65.4] [Average: 92.6] [Max: 118.9]
    4 player scores: [Min: 59.6] [Average: 92.7] [Max: 124.3]
    5 player scores: [Min: 55.1] [Average: 92.7] [Max: 128.2]
    6 player scores: [Min: 49.9] [Average: 90.6] [Max: 129.0]

2022-01-24 22:46: Strategy {"DelayInvestingCards":2,"InvestingCardsLimit":30,"ThrowAwayCheapCards":false,"ThrowAwayCheapSceneCards":false,"ThrowAwayDuplicates":false,"ThrowAwayExpensiveCards":false,"ThrowAwayExpensiveSceneCards":false}
    2 player scores: [Min: 74.8] [Average: 92.1] [Max: 109.4]
    3 player scores: [Min: 65.4] [Average: 91.9] [Max: 117.6]
    4 player scores: [Min: 59.5] [Average: 91.9] [Max: 122.8]
    5 player scores: [Min: 55.1] [Average: 91.9] [Max: 126.5]
    6 player scores: [Min: 49.6] [Average: 89.6] [Max: 127.2]

2022-01-24 23:15: Strategy {"DelayInvestingCards":2,"DoNotThrowAwayCards":false,"InvestingCardsLimit":3,"ThrowAwayCheapCards":true,"ThrowAwayCheapSceneCards":false,"ThrowAwayDuplicates":false,"ThrowAwayExpensiveCards":false,"ThrowAwayExpensiveSceneCards":false}
    2 player scores: [Min: 67.1] [Average: 86.3] [Max: 105.4]
    3 player scores: [Min: 57.5] [Average: 86.5] [Max: 114.8]
    4 player scores: [Min: 50.6] [Average: 86.3] [Max: 120.4]
    5 player scores: [Min: 45.9] [Average: 86.5] [Max: 124.8]
    6 player scores: [Min: 35.5] [Average: 77.6] [Max: 117.4]

2022-01-24 23:11: Strategy {"DelayInvestingCards":2,"DoNotThrowAwayCards":true,"InvestingCardsLimit":3,"ThrowAwayCheapCards":false,"ThrowAwayCheapSceneCards":false,"ThrowAwayDuplicates":false,"ThrowAwayExpensiveCards":false,"ThrowAwayExpensiveSceneCards":false}
    2 player scores: [Min: 75.1] [Average: 92.8] [Max: 110.5]
    3 player scores: [Min: 65.9] [Average: 92.9] [Max: 119.1]
    4 player scores: [Min: 59.6] [Average: 92.7] [Max: 124.3]
    5 player scores: [Min: 55.1] [Average: 92.7] [Max: 128.2]
    6 player scores: [Min: 51.7] [Average: 92.9] [Max: 131.2]

2022-01-24 23:17: Strategy {"DelayInvestingCards":2,"DoNotThrowAwayCards":false,"InvestingCardsLimit":3,"ThrowAwayCheapCards":false,"ThrowAwayCheapSceneCards":false,"ThrowAwayDuplicates":false,"ThrowAwayExpensiveCards":true,"ThrowAwayExpensiveSceneCards":false}
    2 player scores: [Min: 81.4] [Average: 97.5] [Max: 113.6]
    3 player scores: [Min: 73.1] [Average: 97.5] [Max: 121.4]
    4 player scores: [Min: 67.1] [Average: 97.3] [Max: 126.2]
    5 player scores: [Min: 63.2] [Average: 97.3] [Max: 129.7]
    6 player scores: [Min: 53.8] [Average: 87.2] [Max: 120.1]
*/

/*
2022-01-24 23:21: Strategy {"AlsoThrowAwayCardInTurnBeforeLast":true,"DelayInvestingCards":2,"DoNotThrowAwayCards":false,"InvestingCardsLimit":3,"ThrowAwayCheapCards":false,"ThrowAwayCheapSceneCards":false,"ThrowAwayDuplicates":false,"ThrowAwayExpensiveCards":true,"ThrowAwayExpensiveSceneCards":false}
    2 player scores: [Min: 84.6] [Average: 99.5] [Max: 114.3]
    3 player scores: [Min: 77.3] [Average: 99.7] [Max: 121.8]
    4 player scores: [Min: 72.2] [Average: 99.6] [Max: 126.3]
    5 player scores: [Min: 68.5] [Average: 99.4] [Max: 129.6]
    6 player scores: [Min: 58.6] [Average: 88.3] [Max: 119.4]

>>>
2022-01-24 23:29: Strategy {"AlsoThrowAwayCardInTurnBeforeLast":true,"DelayInvestingCards":2,"DoNotThrowAwayCards":false,"InvestingCardsLimit":3,"ThrowAwayCheapCards":false,"ThrowAwayCheapSceneCards":true,"ThrowAwayDuplicates":false,"ThrowAwayExpensiveCards":true,"ThrowAwayExpensiveSceneCards":false}
    2 player scores: [Min: 89.2] [Average: 104.9] [Max: 120.5]
    3 player scores: [Min: 80.0] [Average: 106.3] [Max: 132.1]
    4 player scores: [Min: 68.1] [Average: 101.9] [Max: 135.0]
    5 player scores: [Min: 72.0] [Average: 107.6] [Max: 141.4]
    6 player scores: [Min: 61.7] [Average: 100.4] [Max: 137.8]

2022-01-24 23:29: Strategy {"AlsoThrowAwayCardInTurnBeforeLast":true,"DelayInvestingCards":2,"DoNotThrowAwayCards":false,"InvestingCardsLimit":3,"ThrowAwayCheapCards":false,"ThrowAwayCheapSceneCards":false,"ThrowAwayDuplicates":false,"ThrowAwayExpensiveCards":true,"ThrowAwayExpensiveSceneCards":true}
    2 player scores: [Min: 79.4] [Average: 93.3] [Max: 107.2]
    3 player scores: [Min: 72.9] [Average: 90.4] [Max: 108.3]
    4 player scores: [Min: 73.5] [Average: 94.0] [Max: 114.9]
    5 player scores: [Min: 63.1] [Average: 87.7] [Max: 113.4]
    6 player scores: [Min: 53.2] [Average: 73.8] [Max: 98.6]
*/