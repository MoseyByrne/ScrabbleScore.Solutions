using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleScore.Models;
using System;

namespace Scrabble.Test
{
  [TestClass]
  public class ScrabbleTests
  {

   [TestMethod]
   public void WordConstructor_CreatesInstanceOfWord_true()
   {
    string word = "it";
    Word newWord = new Word(word);
    Assert.AreEqual(word, newWord.Contains);
   }
   [TestMethod]
   public void WordToLetter_ScoreLetters_true()
   {
    string word = "it";
    int wordScore = 2;
    Word newWord = new Word(word);
    Assert.AreEqual(wordScore, newWord.Digits("it"));
   }
  }
}