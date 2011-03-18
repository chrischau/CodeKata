using NUnit.Framework;
using Anagram;

namespace AnagramTest {
  [TestFixture]
  public class CharactersCounterTest {
    [Test]
    public void Count_Set_1() {
      Assert.AreEqual("11100000000000000000000000000000000000", CharactersCounter.Count("ABC"));
    }

    [Test]
    public void Count_Set_2() {
      Assert.AreEqual("11110000000000000000000000000000000000", CharactersCounter.Count("ABCD"));
    }

    [Test]
    public void Count_Set_3() {
      Assert.AreEqual("01113000000010000100000000000000000000", CharactersCounter.Count("December"));
    }

    [Test]
    public void Count_Case_Insensitive() {
      Assert.AreEqual("01113000000010000100000000000000000000", CharactersCounter.Count("DECEMBER"));
    }

    [Test]
    public void Count_hyphen() {
      Assert.AreEqual("00000000000000000000000000100000000000", CharactersCounter.Count("-"));
    }

    [Test]
    public void Count_single_quote() {
      Assert.AreEqual("00000000000000000000000000010000000000", CharactersCounter.Count("\'"));
    }
    
    [Test]
    public void Count_numbers() {
      Assert.AreEqual("00000000000000000000000000001111111111", CharactersCounter.Count("1234567890"));
    }
  }
}
