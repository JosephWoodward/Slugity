using System;
using System.Collections.Generic;
using System.Linq;

namespace SlugityLib
{
    public class CharacterReplacement : ICharacterReplacement
    {
        private readonly Dictionary<string, string> _replacementCharacterStore;

        public IReadOnlyDictionary<string, string> ReplacementCharacters => _replacementCharacterStore;

        public CharacterReplacement()
        {
            _replacementCharacterStore = new Dictionary<string, string>();
        }

        public void Add(string before, string after)
        {
            AddCheck(before, after);

            _replacementCharacterStore.Add(before, after);
        }

        public void AddOrReplace(string before, string after)
        {
            AddCheck(before, after);

            if (_replacementCharacterStore.ContainsKey(before))
                _replacementCharacterStore.Remove(before);
            _replacementCharacterStore.Add(before, after);
        }

        public void Remove(string afterValue)
        {
            if (string.IsNullOrWhiteSpace(afterValue) || string.IsNullOrEmpty(afterValue))
                throw new ArgumentNullException(afterValue);

            var replacement = _replacementCharacterStore.FirstOrDefault(x => x.Value == afterValue);
            if (replacement.Value == null) return;

            _replacementCharacterStore.Remove(replacement.Key);
        }

        private void AddCheck(string before, string after)
        {
            if (before == null)
                throw new ArgumentNullException(nameof(before));
            if (string.IsNullOrWhiteSpace(before))
                throw new ArgumentException("Before parameter cannot be empty");

            if (after == null)
                throw new ArgumentNullException(nameof(after));
        }
    }
}