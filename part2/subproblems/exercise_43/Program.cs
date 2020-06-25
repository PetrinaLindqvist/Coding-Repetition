using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
       int input = Convert.ToInt32(Console.ReadLine());
       if (input < 0)
       {
         Console.WriteLine(input * (-1));
       }
       else
       {
         Console.WriteLine(input);
       }
    }
  }
}
