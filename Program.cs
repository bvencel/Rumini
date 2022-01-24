using Rumini.Entities;
using Rumini.ExtensionMethods;
using Rumini.Helpers;

const int NrPlayers = 3;

static void PrintGame(Game game)
{
    Console.WriteLine(game.ToStringSerialized());
}

bool result = GameHelper.PlayGame(NrPlayers, out Game? game);
if (game is not null)
{
    PrintGame((Game)game);
}