using System;
using System.Collections.Generic;

namespace exercise_110
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<Item> items = new List<Item>();
     
      while (true)
      {
        Console.Write("Name: " );
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        items.Add(new Item(input));
      }
      
      Console.WriteLine();
      foreach(Item item in items)
      {
        Console.WriteLine(item);
      }
    }
  }
}




