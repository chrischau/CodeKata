using System.Linq;
using NUnit.Framework;

namespace Anagram {
  [TestFixture]
  public class WordsCounterTest {

    [Test]
    public void Insert() {
      using (var wordsCounter = WordsCounter.Instance()) {
        const string firstKey = "1";

        wordsCounter.Insert(firstKey, "ABC");

        Assert.AreEqual(1, wordsCounter.WordDictionary.Count());
        Assert.AreEqual(firstKey, wordsCounter.WordDictionary.First().Key);
        Assert.AreEqual(1, wordsCounter.WordDictionary.First().Value.Count);
        Assert.AreEqual("ABC", wordsCounter.WordDictionary.First().Value.First());
      }
    }

    [Test]
    public void Insert_Anagram() {
      using (var wordsCounter = WordsCounter.Instance()) {
        const string firstKey = "1";

        wordsCounter.Insert(firstKey, "ABC");
        wordsCounter.Insert(firstKey, "CBA");

        Assert.AreEqual(1, wordsCounter.WordDictionary.Count());
        Assert.AreEqual(firstKey, wordsCounter.WordDictionary.First().Key);
        Assert.AreEqual(2, wordsCounter.WordDictionary.First().Value.Count);
        Assert.AreEqual("ABC", wordsCounter.WordDictionary.First().Value.First());
        Assert.AreEqual("CBA", wordsCounter.WordDictionary.First().Value[1]);
      }
    }

    [Test]
    public void Insert_Multiple() {
      using (var wordsCounter = WordsCounter.Instance()) {
        const string firstKey = "1";
        const string secondKey = "2";

        wordsCounter.Insert(firstKey, "ABC");
        wordsCounter.Insert(secondKey, "ABCD");

        Assert.AreEqual(2, wordsCounter.WordDictionary.Count());
        Assert.AreEqual(firstKey, wordsCounter.WordDictionary.First().Key);
        Assert.IsNotNull(wordsCounter.WordDictionary[secondKey]);
        Assert.AreEqual("ABC", wordsCounter.WordDictionary.First().Value.First());
        Assert.AreEqual("ABCD", wordsCounter.WordDictionary[secondKey].First());
      }
    }

    [Test]
    public void Insert_Duplicate() {
      using (var wordsCounter = WordsCounter.Instance()) {
        const string firstKey = "1";

        wordsCounter.Insert(firstKey, "ABC");
        wordsCounter.Insert(firstKey, "ABC");

        Assert.AreEqual(1, wordsCounter.WordDictionary.Count());
        Assert.AreEqual(firstKey, wordsCounter.WordDictionary.First().Key);
        Assert.AreEqual(1, wordsCounter.WordDictionary.First().Value.Count());
        Assert.AreEqual("ABC", wordsCounter.WordDictionary.First().Value.First());
      }
    }

    [Test]
    public void Insert_Duplicate_Case_Sensitive() {
      using (var wordsCounter = WordsCounter.Instance()) {
        const string firstKey = "1";

        wordsCounter.Insert(firstKey, "ABC");
        wordsCounter.Insert(firstKey, "abc");

        Assert.AreEqual(1, wordsCounter.WordDictionary.Count());
        Assert.AreEqual(firstKey, wordsCounter.WordDictionary.First().Key);
        Assert.AreEqual(2, wordsCounter.WordDictionary.First().Value.Count());
        Assert.AreEqual("ABC", wordsCounter.WordDictionary.First().Value.First());
        Assert.AreEqual("abc", wordsCounter.WordDictionary.First().Value[1]);
      }
    }

  }

  [TestFixture]
  public class WordCounterByPrimeNumberTest {

    [Test]
    public void Insert_By_Long() {
      using (var wordsCounter = WordsCounter.Instance()) {
        const long firstKey = 1;

        wordsCounter.Insert(firstKey, "ABC");

        Assert.AreEqual(1, wordsCounter.WordDictionaryByPrimeNumber.Count());
        Assert.AreEqual(firstKey, wordsCounter.WordDictionaryByPrimeNumber.First().Key);
        Assert.AreEqual(1, wordsCounter.WordDictionaryByPrimeNumber.First().Value.Count);
        Assert.AreEqual("ABC", wordsCounter.WordDictionaryByPrimeNumber.First().Value.First());
      }
    }

    [Test]
    public void Insert_Anagram_By_Long() {
      using (var wordsCounter = WordsCounter.Instance()) {
        const long firstKey = 1;

        wordsCounter.Insert(firstKey, "ABC");
        wordsCounter.Insert(firstKey, "CBA");

        Assert.AreEqual(1, wordsCounter.WordDictionaryByPrimeNumber.Count());
        Assert.AreEqual(firstKey, wordsCounter.WordDictionaryByPrimeNumber.First().Key);
        Assert.AreEqual(2, wordsCounter.WordDictionaryByPrimeNumber.First().Value.Count);
        Assert.AreEqual("ABC", wordsCounter.WordDictionaryByPrimeNumber.First().Value.First());
        Assert.AreEqual("CBA", wordsCounter.WordDictionaryByPrimeNumber.First().Value[1]);
      }
    }

    [Test]
    public void Insert_Multiple_By_Long() {
      using (var wordsCounter = WordsCounter.Instance()) {
        const long firstKey = 1;
        const long secondKey = 2;

        wordsCounter.Insert(firstKey, "ABC");
        wordsCounter.Insert(secondKey, "ABCD");

        Assert.AreEqual(2, wordsCounter.WordDictionaryByPrimeNumber.Count());
        Assert.AreEqual(firstKey, wordsCounter.WordDictionaryByPrimeNumber.First().Key);
        Assert.IsNotNull(wordsCounter.WordDictionaryByPrimeNumber[secondKey]);
        Assert.AreEqual("ABC", wordsCounter.WordDictionaryByPrimeNumber.First().Value.First());
        Assert.AreEqual("ABCD", wordsCounter.WordDictionaryByPrimeNumber[secondKey].First());
      }
    }

    [Test]
    public void Insert_Duplicate_By_Long() {
      using (var wordsCounter = WordsCounter.Instance()) {
        const long firstKey = 1;

        wordsCounter.Insert(firstKey, "ABC");
        wordsCounter.Insert(firstKey, "ABC");

        Assert.AreEqual(1, wordsCounter.WordDictionaryByPrimeNumber.Count());
        Assert.AreEqual(firstKey, wordsCounter.WordDictionaryByPrimeNumber.First().Key);
        Assert.AreEqual(1, wordsCounter.WordDictionaryByPrimeNumber.First().Value.Count());
        Assert.AreEqual("ABC", wordsCounter.WordDictionaryByPrimeNumber.First().Value.First());
      }
    }

    [Test]
    public void Insert_Duplicate_Case_Sensitive_By_Long() {
      using (var wordsCounter = WordsCounter.Instance()) {
        const long firstKey = 1;

        wordsCounter.Insert(firstKey, "ABC");
        wordsCounter.Insert(firstKey, "abc");

        Assert.AreEqual(1, wordsCounter.WordDictionaryByPrimeNumber.Count());
        Assert.AreEqual(firstKey, wordsCounter.WordDictionaryByPrimeNumber.First().Key);
        Assert.AreEqual(2, wordsCounter.WordDictionaryByPrimeNumber.First().Value.Count());
        Assert.AreEqual("ABC", wordsCounter.WordDictionaryByPrimeNumber.First().Value.First());
        Assert.AreEqual("abc", wordsCounter.WordDictionaryByPrimeNumber.First().Value[1]);
      }
    }

  }
}
