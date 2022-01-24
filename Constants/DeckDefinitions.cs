using Rumini.Entities;
using Rumini.Enums;

namespace Rumini.Constants
{
    internal static class DeckDefinitions
    {
        public static List<CharacterCard> CharacterCards => new()
        {
            new CharacterCard() { Id = 0, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 1, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 2, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 3, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 4, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 5, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 6, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 7, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 8, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 9, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 10, CharacterOfCard = Character.Rumini },
            new CharacterCard() { Id = 11, CharacterOfCard = Character.Rumini },

            new CharacterCard() { Id = 12, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 13, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 14, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 15, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 16, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 17, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 18, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 19, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 20, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 21, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 22, CharacterOfCard = Character.Baliko },
            new CharacterCard() { Id = 23, CharacterOfCard = Character.Baliko },

            new CharacterCard() { Id = 24, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 25, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 26, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 27, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 28, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 29, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 30, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 31, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 32, CharacterOfCard = Character.Feco },
            new CharacterCard() { Id = 33, CharacterOfCard = Character.Feco },

            new CharacterCard() { Id = 34, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { Id = 35, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { Id = 36, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { Id = 37, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { Id = 38, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { Id = 39, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { Id = 40, CharacterOfCard = Character.Kapitany },
            new CharacterCard() { Id = 41, CharacterOfCard = Character.Kapitany },

            new CharacterCard() { Id = 42, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { Id = 43, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { Id = 44, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { Id = 45, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { Id = 46, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { Id = 47, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { Id = 48, CharacterOfCard = Character.Sebestyen },
            new CharacterCard() { Id = 49, CharacterOfCard = Character.Sebestyen },

            new CharacterCard() { Id = 50, CharacterOfCard = Character.Negro },
            new CharacterCard() { Id = 51, CharacterOfCard = Character.Negro },
            new CharacterCard() { Id = 52, CharacterOfCard = Character.Negro },
            new CharacterCard() { Id = 53, CharacterOfCard = Character.Negro },
            new CharacterCard() { Id = 54, CharacterOfCard = Character.Negro },
            new CharacterCard() { Id = 55, CharacterOfCard = Character.Negro },

            new CharacterCard() { Id = 56, CharacterOfCard = Character.Bandi },
            new CharacterCard() { Id = 57, CharacterOfCard = Character.Bandi },
            new CharacterCard() { Id = 58, CharacterOfCard = Character.Bandi },
            new CharacterCard() { Id = 59, CharacterOfCard = Character.Bandi },

            new CharacterCard() { Id = 60, CharacterOfCard = Character.Johanna },
            new CharacterCard() { Id = 61, CharacterOfCard = Character.Johanna },
            new CharacterCard() { Id = 62, CharacterOfCard = Character.Johanna },
            new CharacterCard() { Id = 63, CharacterOfCard = Character.Johanna },

            new CharacterCard() { Id = 64, CharacterOfCard = Character.Rozi },
            new CharacterCard() { Id = 65, CharacterOfCard = Character.Rozi },

            new CharacterCard() { Id = 66, CharacterOfCard = Character.Oriaspolip },
            new CharacterCard() { Id = 67, CharacterOfCard = Character.Oriaspolip },
        };

        public static List<SceneCard> SceneCards => new()
        {
            new SceneCard
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard= Character.Rumini},
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko },
                    new SceneCardCharacter { CharacterOfCard = Character.Feco },
                    new SceneCardCharacter { CharacterOfCard = Character.Kapitany },
                    new SceneCardCharacter { CharacterOfCard = Character.Sebestyen },
                    new SceneCardCharacter { CharacterOfCard = Character.Negro } },
                PointValue = 2,
                Text = "Rumini lovagga avatasa...",
            },

            new SceneCard
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard= Character.Rumini},
                    new SceneCardCharacter { CharacterOfCard= Character.Baliko},
                    new SceneCardCharacter { CharacterOfCard= Character.Feco },
                    new SceneCardCharacter { CharacterOfCard= Character.Kapitany },
                    new SceneCardCharacter { CharacterOfCard = Character.Sebestyen },
                    new SceneCardCharacter { CharacterOfCard= Character.Negro } },
                PointValue = 2,
                Text = "Strandol...",
            },

            new SceneCard
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini },
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko },
                    new SceneCardCharacter { CharacterOfCard = Character.Kapitany },
                    new SceneCardCharacter { CharacterOfCard = Character.Sebestyen },
                    new SceneCardCharacter { CharacterOfCard = Character.Negro },
                    new SceneCardCharacter { CharacterOfCard = Character.Bandi } },
                PointValue = 2,
                Text = "A szelkiralyno fed...",
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini },
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko },
                    new SceneCardCharacter { CharacterOfCard = Character.Feco },
                    new SceneCardCharacter { CharacterOfCard = Character.Kapitany },
                    new SceneCardCharacter { CharacterOfCard = Character.Rozi } },
                PointValue = 3,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini },
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko },
                    new SceneCardCharacter { CharacterOfCard = Character.Feco },
                    new SceneCardCharacter { CharacterOfCard = Character.Sebestyen },
                    new SceneCardCharacter { CharacterOfCard = Character.Johanna } },
                PointValue = 3,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko },
                    new SceneCardCharacter { CharacterOfCard = Character.Feco },
                    new SceneCardCharacter { CharacterOfCard = Character.Kapitany },
                    new SceneCardCharacter { CharacterOfCard = Character.Sebestyen } },
                PointValue = 4,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini },
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko },
                    new SceneCardCharacter { CharacterOfCard = Character.Feco },
                    new SceneCardCharacter { CharacterOfCard = Character.Kapitany } },
                PointValue = 4,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini },
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko },
                    new SceneCardCharacter { CharacterOfCard = Character.Negro },
                    new SceneCardCharacter { CharacterOfCard = Character.Bandi } },
                PointValue = 4,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini },
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko },
                    new SceneCardCharacter { CharacterOfCard = Character.Feco } },
                PointValue = 5,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini },
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko },
                    new SceneCardCharacter { CharacterOfCard = Character.Feco } },
                PointValue = 5,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini },
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko },
                    new SceneCardCharacter { CharacterOfCard = Character.Feco } },
                PointValue = 5,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini },
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko },
                    new SceneCardCharacter { CharacterOfCard = Character.Negro } },
                PointValue = 5,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini },
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko },
                    new SceneCardCharacter { CharacterOfCard = Character.Sebestyen } },
                PointValue = 5,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini },
                    new SceneCardCharacter { CharacterOfCard = Character.Feco },
                    new SceneCardCharacter { CharacterOfCard = Character.Johanna } },
                PointValue = 5,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko },
                    new SceneCardCharacter { CharacterOfCard = Character.Feco } },
                PointValue = 6,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko },
                    new SceneCardCharacter { CharacterOfCard = Character.Feco } },
                PointValue = 6,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko },
                    new SceneCardCharacter { CharacterOfCard = Character.Sebestyen } },
                PointValue = 6,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Feco },
                    new SceneCardCharacter { CharacterOfCard = Character.Johanna } },
                PointValue = 6,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Feco },
                    new SceneCardCharacter { CharacterOfCard = Character.Kapitany } },
                PointValue = 6,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Kapitany },
                    new SceneCardCharacter { CharacterOfCard = Character.Sebestyen } },
                PointValue = 6,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini },
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko } },
                PointValue = 6,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini },
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko } },
                PointValue = 6,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini },
                    new SceneCardCharacter { CharacterOfCard = Character.Kapitany } },
                PointValue = 6,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini },
                    new SceneCardCharacter { CharacterOfCard = Character.Negro } },
                PointValue = 6,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini },
                    new SceneCardCharacter { CharacterOfCard = Character.Rozi } },
                PointValue = 6,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Baliko } },
                PointValue = 8,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Bandi } },
                PointValue = 8,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Feco } },
                PointValue = 8,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Feco } },
                PointValue = 8,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Negro } },
                PointValue = 8,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Rumini } },
                PointValue = 8,
            },
            new SceneCard()
            {
                Characters = new List<SceneCardCharacter> {
                    new SceneCardCharacter { CharacterOfCard = Character.Sebestyen } },
                PointValue = 8,
            }
        };
    }
}