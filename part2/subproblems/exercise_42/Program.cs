using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int input = Convert.ToInt32(Console.ReadLine());
      int input2 = Convert.ToInt32(Console.ReadLine());
     
      int number = input + input2;
      double squareRoot = Math.Sqrt(number);
      Console.WriteLine(squareRoot);
    
    
    }
  }
}
