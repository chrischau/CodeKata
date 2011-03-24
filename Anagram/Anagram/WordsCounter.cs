using System;
using System.Collections.Generic;

namespace Anagram {
  public class WordsCounter : IDisposable {

    WordsCounter() {
      WordDictionary = new Dictionary<string, List<string>>();
      WordDictionaryByPrimeNumber = new Dictionary<long, List<string>>();
    }

    static WordsCounter wordsCounter;
    public static WordsCounter Instance() {
      return wordsCounter ?? (wordsCounter = new WordsCounter());
    }

    public Dictionary<string, List<string>> WordDictionary { get; set; }
    public Dictionary<long, List<string>> WordDictionaryByPrimeNumber { get; set; }

    public void Insert(string wordValue, string word) {
      if (!WordDictionary.ContainsKey(wordValue)) 
        WordDictionary.Add(wordValue, new List<string>());

      if (!WordDictionary[wordValue].Contains(word))
        WordDictionary[wordValue].Add(word);
    }

    public void Insert(long wordValue, string word) {
      if (!WordDictionaryByPrimeNumber.ContainsKey(wordValue))
        WordDictionaryByPrimeNumber.Add(wordValue, new List<string>());

      if (!WordDictionaryByPrimeNumber[wordValue].Contains(word))
        WordDictionaryByPrimeNumber[wordValue].Add(word);
    }

    public void Dispose() {
      wordsCounter = null;
    }
  }
}
