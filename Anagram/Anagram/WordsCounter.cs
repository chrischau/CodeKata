using System;
using System.Collections.Generic;

namespace Anagram {
  public class WordsCounter : IDisposable {

    WordsCounter() {
      WordDictionary = new Dictionary<string, List<string>>();
    }

    static WordsCounter wordsCounter;
    public static WordsCounter Instance() {
      return wordsCounter ?? (wordsCounter = new WordsCounter());
    }

    public Dictionary<string, List<string>> WordDictionary { get; set; }

    public void Insert(string wordValue, string word) {
      if (!WordDictionary.ContainsKey(wordValue)) 
        WordDictionary.Add(wordValue, new List<string>());

      if (!WordDictionary[wordValue].Contains(word))
        WordDictionary[wordValue].Add(word);
    }

    public void Dispose() {
      wordsCounter = null;
    }
  }
}
