// See https://aka.ms/new-console-template for more information
using Rumini;

const int MinPlayers = 2;
const int MaxPlayers = 6;

List<SceneCard> SceneCards = new()
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

List<CharacterCard> CharacterCards = new()
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

Console.WriteLine(SceneCards.Count);

Console.WriteLine(CharacterCards.Count);
