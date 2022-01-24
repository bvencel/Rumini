using Rumini.Enums;
using Rumini.Helpers;

using System.Diagnostics;

namespace Rumini.Entities
{
    /// <summary>
    /// Represents one of the characters enumerated on a score card.
    /// </summary>
    [DebuggerDisplay("Character = {CharacterOfCard}")]
    internal class SceneCardCharacter
    {
        public Character CharacterOfCard { get; set; }

        public int PointValue
        {
            get
            {
                return CharacterCardHelper.GetCharacterPointValue(CharacterOfCard);
            }
        }
    }
}