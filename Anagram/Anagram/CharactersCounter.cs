using System.Collections.Generic;
using System.Linq;

namespace Anagram {
  public class CharactersCounter {

    CharactersCounter() {
      wordCharacterDictionary = new Dictionary<char, int> {
          { 'a', 0 },
          { 'b', 0 },
          { 'c', 0 },
          { 'd', 0 },
          { 'e', 0 },
          { 'f', 0 },
          { 'g', 0 },
          { 'h', 0 },
          { 'i', 0 },
          { 'j', 0 },
          { 'k', 0 },
          { 'l', 0 },
          { 'm', 0 },
          { 'n', 0 },
          { 'o', 0 },
          { 'p', 0 },
          { 'q', 0 },
          { 'r', 0 },
          { 's', 0 },
          { 't', 0 },
          { 'u', 0 },
          { 'v', 0 },
          { 'w', 0 },
          { 'x', 0 },
          { 'y', 0 },
          { 'z', 0 },
          { '-', 0 },
          { '\'', 0 },
          { '1', 0 },
          { '2', 0 },
          { '3', 0 },
          { '4', 0 },
          { '5', 0 },
          { '6', 0 },
          { '7', 0 },
          { '8', 0 },
          { '9', 0 },
          { '0', 0 },
        };
    }

    static Dictionary<char, int> wordCharacterDictionary { get; set; }

    public static string Count(string word) {
      new CharactersCounter();

      foreach (var character in word.ToLower().ToCharArray()) {
        wordCharacterDictionary[character]++;
      }

      // this line of code is not as performant compare to the loop above
      //word.ToLower().ToCharArray().ToList<char>().ForEach(character => wordCharacterDictionary[character]++);

      return wordCharacterDictionary.Select(key => key.Value.ToString()).Aggregate((a, b) => a + b);
    }
  }
}
