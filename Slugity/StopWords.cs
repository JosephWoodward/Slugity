﻿using System;
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
            if (words == null) return;
            foreach (var word in words)
            {
                if (word != null) StopWordsStore.Add(word);
            }
        }

        public void Remove(params string[] words)
        {
            if (words == null) return;
            foreach (var word in words)
            {
                if (word != null) StopWordsStore.Remove(word);
            }
        }
    }
}
