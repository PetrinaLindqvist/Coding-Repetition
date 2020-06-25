using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int input = Convert.ToInt32(Console.ReadLine());
      while (input <= 100)
      {
        Console.WriteLine(input);
        input++;
      }
    }
  }
}
