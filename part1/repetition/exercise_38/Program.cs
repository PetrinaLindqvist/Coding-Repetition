using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int sum = 0;
      while (true)
       {
          Console.WriteLine("Give a number:");
          int nbr = Convert.ToInt32(Console.ReadLine());

          if (nbr == 0)
          {
            break;
          }
          else if (nbr < 0)
          {
            sum = sum + 1;
          }
        }
        Console.WriteLine("Total amount of negative numbers: " + sum);
        

    }
  }
}
