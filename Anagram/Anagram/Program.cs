using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anagram {
  class Program {

    static void Main(string[] args) {
      var wordCounter = WordsCounter.Instance();

      Console.WriteLine("Anagram...");
      var time = DateTime.Now;

      int wordCount = 0;
      using (var reader = new StreamReader(@"..\..\..\wordlist.txt")) {
        while (!reader.EndOfStream) {
          var word = reader.ReadLine();          
          wordCounter.Insert(CharactersCounter.Count(word), word);
          wordCount++;
        }
      }

      Console.WriteLine(@"Took {0} seconds to process {1} words. ", 
                        (DateTime.Now - time).TotalSeconds,
                        wordCount);

      Output(wordCounter);
      
      Console.WriteLine("Finish.");
      Console.ReadLine();
    }

    static void Output(WordsCounter wordCounter) {
      using (var writer = new StreamWriter("Anagram Output.txt")) {
        foreach (var words in wordCounter.WordDictionary.OrderByDescending(list => list.Value.Count())) {
          foreach (var word in words.Value) {
            //Console.Write(word + " ");
            writer.Write(word + " ");
          }
          //Console.WriteLine();
          writer.WriteLine();
        }
      }
    }
  }
}
