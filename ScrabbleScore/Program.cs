using System;
using ScrabbleScore.Models;

class Program
{

  public static void Main()
  {
    Console.WriteLine("Enter your scrabble word, and I'll tell you it's score");
    string userInput = Console.ReadLine();
    Word newWord = new Word(userInput);
    int result = newWord.Digits(userInput);
    Console.WriteLine("Your score is:" + result);
  }
}
