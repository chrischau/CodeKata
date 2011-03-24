using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anagram {
  public class CharactersCounterByPrimeNumbers {
    CharactersCounterByPrimeNumbers() {
      wordCharacterDictionary = new Dictionary<char, int> {
          { 'a', 11 },
          { 'b', 13 },
          { 'c', 17 },
          { 'd', 19 },
          { 'e', 23 },
          { 'f', 29 },
          { 'g', 31 },
          { 'h', 37 },
          { 'i', 41 },
          { 'j', 43 },
          { 'k', 47 },
          { 'l', 53 },
          { 'm', 59 },
          { 'n', 61 },
          { 'o', 67 },
          { 'p', 71 },
          { 'q', 73 },
          { 'r', 79 },
          { 's', 83 },
          { 't', 89 },
          { 'u', 97 },
          { 'v', 101 },
          { 'w', 103 },
          { 'x', 107 },
          { 'y', 109 },
          { 'z', 113 },
          { '-', 127 },
          { '\'', 131 },
          { '1', 137 },
          { '2', 139 },
          { '3', 149 },
          { '4', 151 },
          { '5', 157 },
          { '6', 163 },
          { '7', 167 },
          { '8', 173 },
          { '9', 179 },
          { '0', 181 },
        };
    }

    static Dictionary<char, int> wordCharacterDictionary { get; set; }

    public static long Count(string word) {
      new CharactersCounterByPrimeNumbers();

      long wordValue = 1;
      foreach (var character in word.ToLower().ToCharArray()) {
        wordValue *= wordCharacterDictionary[character];
      }

      return wordValue;

      //foreach (var character in word.ToLower().ToCharArray()) {
      //  wordCharacterDictionary[character]++;
      //}

      //// this line of code is not as performant compare to the loop above
      ////word.ToLower().ToCharArray().ToList<char>().ForEach(character => wordCharacterDictionary[character]++);

      //return wordCharacterDictionary.Select(key => key.Value.ToString()).Aggregate((a, b) => a + b);
    }
  }
}

