namespace SlugityLib
{
    public interface ICharacterReplacement
    {
        /// <summary>
        /// Add a character or word that will be replaced in your slug.
        /// </summary>
        /// <param name="before">Before character or word(s)</param>
        /// <param name="after">After character or word(s)</param>
        void Add(string before, string after);

        /// <summary>
        /// Add or replace an existing character or word already set for replacement.
        /// </summary>
        /// <param name="before">Before character or word(s)</param>
        /// <param name="after">After character or word(s)</param>
        void AddOrReplace(string before, string after);

        /// <summary>
        /// Remove a character or word from character replacement collection.
        /// </summary>
        /// <param name="character">Character or word to be removed from replacement collection</param>
        void Remove(string character);
    }
}