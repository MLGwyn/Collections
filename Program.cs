using System;
using System.Collections.Generic; 

namespace Collections
{
  class Program
  {
    static void Main(string[] args)
    {
      var names = new List<string>() { "Mark", "Paul", "Sandy", "Bill" };

      var firstName = names[0];
      var secondName = names[1];
      var finalName = names[3];

      Console.WriteLine (firstName);
      Console.WriteLine (names.Count);  

      names.Add("George");
      Console.WriteLine(names.Count); 

      names.Insert(2, "Frank");

      var scores = new List<int>();
      scores.Add (12);
      scores.Add (100);
      scores.Add (55);
      scores.Add (44);
      scores.Add (12);

      var lastIndex = scores.Count -1;
      var lastScore = scores[lastIndex];

      var indexOfFiftyFive = scores.IndexOf(55);
      Console.WriteLine ($"Found 55 at index {indexOfFiftyFive}");

      var indexOfFortyTwo = scores.IndexOf(42);
      Console.WriteLine($"Found 42 at index {indexOfFortyTwo}");

      var indexOfTwelve = scores.LastIndexOf(12);
      Console.WriteLine($"Found 12 at index {indexOfTwelve}");





    } 
  }
}
