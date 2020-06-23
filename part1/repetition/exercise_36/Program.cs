using System;

namespace exercise_36
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

        if (nbr < 0)
        {
          Console.WriteLine("That is negative");
        }
        else if (nbr > 0)
        {
          Console.WriteLine(nbr * nbr);
        }
        else if (nbr == 0)
        {
          break;
        }
      }

    }
  }
}
