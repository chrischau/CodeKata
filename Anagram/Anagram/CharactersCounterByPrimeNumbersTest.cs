using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Anagram;

namespace AnagramTest {
  [TestFixture]
  public class CharactersCounterByPrimeNumbersTest {
    [Test]
    public void Count_Set_1() {
      Assert.AreEqual(11 * 13 * 17, CharactersCounterByPrimeNumbers.Count("ABC"));
    }

    [Test]
    public void Count_Set_2() {
      Assert.AreEqual(11 * 13 * 17 * 19, CharactersCounterByPrimeNumbers.Count("ABCD"));
    }

    [Test]
    public void Count_Set_3() {
      unchecked {
        long wordValue = (long)19 * (long)23 * (long)17 * (long)23 * (long)59 * (long)13 * (long)23 * (long)79;
        Assert.AreEqual(wordValue, CharactersCounterByPrimeNumbers.Count("December"));
      }
    }

    [Test]
    public void Count_Case_Insensitive() {
      unchecked {
        long wordValue = (long)19 * (long)23 * (long)17 * (long)23 * (long)59 * (long)13 * (long)23 * (long)79;
        Assert.AreEqual(wordValue, CharactersCounterByPrimeNumbers.Count("DECEMBER"));
      }
    }

    [Test]
    public void Count_hyphen() {
      Assert.AreEqual(127, CharactersCounterByPrimeNumbers.Count("-"));
    }

    [Test]
    public void Count_single_quote() {
      Assert.AreEqual(131, CharactersCounterByPrimeNumbers.Count("\'"));
    }

    [Test]
    public void Count_numbers() {
      unchecked {
        long wordValue = (long)137 * (long)139 * (long)149 * (long)151 * (long)157 * (long)163 * (long)167 * (long)173 * (long)179 * (long)181;
        Assert.AreEqual(wordValue, CharactersCounterByPrimeNumbers.Count("1234567890"));
      }
    }
  }
}
