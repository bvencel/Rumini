using Rumini.Enums;

using System.Diagnostics;

namespace Rumini.Entities
{
    [DebuggerDisplay("Character = {CharacterOfCard}")]
    internal class CharacterCard : ICloneable
    {
        public Character CharacterOfCard { get; set; }

        public int PointValue { get; set; }

        public object Clone()
        {
            return new CharacterCard()
            {
                CharacterOfCard = CharacterOfCard,
                PointValue = PointValue,
            };
        }
    }
}