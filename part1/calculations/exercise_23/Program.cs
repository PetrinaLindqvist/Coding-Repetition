using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      int nbr1 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Give the second number!");
      int nbr2 = Convert.ToInt32(Console.ReadLine());

      int sum1 = (nbr1 + nbr2);
      int sum2 = (nbr1 - nbr2);
      int sum3 = (nbr1 * nbr2);
      double sum4 = (double)nbr1/nbr2;

      Console.WriteLine(nbr1 + " + " + nbr2 + " = " + sum1);
      Console.WriteLine(nbr1 + " - " + nbr2 + " = " + sum2);
      Console.WriteLine(nbr1 + " * " + nbr2 + " = " + sum3);
      Console.WriteLine(nbr1 + " / " + nbr2 + " = " + sum4);
    }
  }
}
