using System;
using System.Collections.Generic;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
       Console.WriteLine("Search for?");
       string search = Console.ReadLine();
       if (list.Contains(search))
       {
         Console.WriteLine(search + " was found!");
       }
       else
       {
         Console.WriteLine(search + " was not found!");
       }

      
    }
  }
}

