﻿using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("How many days?");
      int days = Convert.ToInt32(Console.ReadLine());
      int secondsDay = (86400 * days);
      Console.WriteLine(secondsDay);

    }
  }
}
