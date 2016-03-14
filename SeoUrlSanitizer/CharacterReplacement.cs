using System.Collections.Generic;

namespace SeoUrlSanitizer
{
    public class CharacterReplacement
    {
        private readonly Dictionary<string, string> replacementCharacterStore;

        private IDictionary<string, string> ReplacementCharacters => replacementCharacterStore;

        public CharacterReplacement()
        {
            replacementCharacterStore = new Dictionary<string, string>();
        }

        public void Add(string before, string after)
        {
            replacementCharacterStore.Add(before, after);
        }
    }
}