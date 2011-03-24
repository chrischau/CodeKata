using System;
using System.IO;
using System.Linq;

namespace Anagram {
  class Program {

    static void Main(string[] args) {
      var wordCounter = WordsCounter.Instance();

      Console.WriteLine("Anagram...");
      Console.WriteLine();
      Console.WriteLine("Using Character List Method");

      AnagramByCharacterList(wordCounter, DateTime.Now);

      Console.WriteLine();
      Console.WriteLine("Using Character Prime Number Method");

      AnagramByPrimeNumber(wordCounter, DateTime.Now);

      Console.WriteLine();
      Console.WriteLine("Finished.");
      Console.ReadLine();
    }

    static void AnagramByPrimeNumber(WordsCounter wordCounter, DateTime time) {
      using (var reader = new StreamReader(@"..\..\..\wordlist.txt")) {
        while (!reader.EndOfStream) {
          var word = reader.ReadLine();
          wordCounter.Insert(CharactersCounterByPrimeNumbers.Count(word), word);
        }
      }

      var timeTook = (DateTime.Now - time).TotalSeconds;

      Console.WriteLine(@"Took {0} seconds to process {1} words. ",
                        timeTook,
                        wordCount);

      Output(wordCounter, "Anagram By Prime Number Output.txt", timeTook);
    }

    static int wordCount = 0;

    static void AnagramByCharacterList(WordsCounter wordCounter, DateTime time) {
      wordCount = 0;

      using (var reader = new StreamReader(@"..\..\..\wordlist.txt")) {
        while (!reader.EndOfStream) {
          var word = reader.ReadLine();
          wordCounter.Insert(CharactersCounter.Count(word), word);
          wordCount++;
        }
      }

      var timeTook = (DateTime.Now - time).TotalSeconds;

      Console.WriteLine(@"Took {0} seconds to process {1} words. ",
                        timeTook,
                        wordCount);

      Output(wordCounter, "Anagram By Character List Output.txt", timeTook);
    }

    static void Output(WordsCounter wordCounter, string fileName, double timeTook) {
      using (var writer = new StreamWriter(fileName)) {
        foreach (var words in wordCounter.WordDictionary.OrderByDescending(list => list.Value.Count())) {
          foreach (var word in words.Value) {
            //Console.Write(word + " ");
            writer.Write(word + " ");
          }
          //Console.WriteLine();
          writer.WriteLine();
        }
        writer.WriteLine();
        writer.WriteLine("Time took: {0} seconds", timeTook);
      }
    }
  }
}
