using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      while (true)
      {
        Console.WriteLine("Give a number:");
        int nbr = Convert.ToInt32(Console.ReadLine());

        if (nbr == 42)
        {
          break;
        }
      }
    }
  }
}
