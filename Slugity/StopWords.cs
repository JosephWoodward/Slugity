using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlugityLib;

namespace Slugity
{
    public class StopWords : IStopWords
    {
        public List<string> StopWordsStore { get; } = new List<string>();

        public StopWords()
        {
            StopWordsStore.AddRange(DefaultStopWords.StopWordList);
        }

        public void Add(params string[] words)
        {
            if (words != null) StopWordsStore.AddRange(words);
        }

        public void Remove(params string[] words)
        {
            foreach (var word in words)
            {
                StopWordsStore.Remove(word);
            }
        }
    }
}
