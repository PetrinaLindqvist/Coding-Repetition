﻿using System;

namespace exercise_22
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

      Console.WriteLine("Give the third number!");
      int nbr3 = Convert.ToInt32(Console.ReadLine());

      double average = (nbr1+nbr2+nbr3) / 3.0;
      Console.WriteLine("The average is " + average);

    }
  }
}
