using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int input = Convert.ToInt32(Console.ReadLine());
      int input2 = Convert.ToInt32(Console.ReadLine());
     
      if(input > input2)
      {
        Console.WriteLine(input + " is greater than " + input2 + "." );
      }
      else if (input < input2)
      {
        Console.WriteLine(input + " is less than " + input2 + "." );
      }
      else
      {
          Console.WriteLine(input + " is equal to " + input2 + "." );
      }
    }
  }
}
