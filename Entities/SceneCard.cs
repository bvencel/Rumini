namespace Rumini.Entities
{
    internal class SceneCard : ICloneable
    {
        public List<SceneCardCharacter> Characters { get; set; } = new();

        public int PointValue
        {
            get; set;
        }

        /// <summary>
        ///  Used to differentiate between cards.
        /// </summary>
        public string Text { get; set; } = string.Empty;

        public object Clone()
        {
            SceneCard clone = new()
            {
                PointValue = PointValue,
            };

            foreach (SceneCardCharacter item in Characters)
            {
                clone.Characters.Add(item);
            }

            return clone;
        }
    }
}