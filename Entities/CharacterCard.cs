using Rumini.Enums;
using Rumini.Helpers;

using System.Diagnostics;

namespace Rumini.Entities
{
    [DebuggerDisplay("Character = {CharacterOfCard}")]
    internal class CharacterCard : ICloneable
    {
        public Character CharacterOfCard { get; set; }

        /// <summary>
        /// Unique number so cards can be easily identified
        /// </summary>
        public int Id { get; set; }

        public int PointValue
        {
            get
            {
                return CharacterCardHelper.GetCharacterPointValue(PlayedAsCharacter);
            }
        }

        public bool IsSquid => CharacterOfCard == Character.Oriaspolip;

        Character playedAsCharacter;

        /// <summary>
        /// If the card 
        /// </summary>
        public Character PlayedAsCharacter
        {
            get
            {

                if (IsSquid)
                {
                    return playedAsCharacter;
                }

                return CharacterOfCard;
            }
            set
            {
                playedAsCharacter = value;
            }
        }

        public object Clone()
        {
            return new CharacterCard()
            {
                CharacterOfCard = CharacterOfCard,
                Id = Id,
            };
        }
    }
}