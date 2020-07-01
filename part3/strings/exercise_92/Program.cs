using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> names = new List<string>();

      int length = 0;
      string longestName = "";
      int nameLength = 0;
      int age = 0;
      int oldest = 2020;

      while (true)
      {
        string input = Console.ReadLine();

        if (input == "")
        {
          break;
        }

        string[] parts = input.Split(",");

        string word = parts[0];
        length = word.Length;

        if (length > nameLength)
        {
          nameLength = length;
          longestName = parts[0];
        }

        if (Convert.ToInt32(parts[1]) < oldest)
        {
          oldest = Convert.ToInt32(parts[1]);
        }
      }

      age = 2020 - oldest;

      Console.WriteLine("Longest name: " + longestName);
      Console.WriteLine("Highest age: " + age);
      
    }
  }
}



