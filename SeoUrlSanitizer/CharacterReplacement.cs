using System.Collections.Generic;

namespace SeoUrlSanitizer
{
    public class CharacterReplacement
    {
        private readonly Dictionary<string, string> _replacementCharacterStore;

        public CharacterReplacement()
        {
            _replacementCharacterStore = new Dictionary<string, string>();
        }

        public void Add(string before, string after)
        {
            _replacementCharacterStore.Add(before, after);
        }

        public void AddOrReplace(string before, string after)
        {
            if (_replacementCharacterStore.ContainsKey(before))
                _replacementCharacterStore.Remove(before);
            _replacementCharacterStore.Add(before, after);
        }

        public void Remove(string before)
        {
            _replacementCharacterStore.Remove(before);
        }
    }
}