using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int sum = 0;
      int amount = 0;
      int even = 0;
      int odd = 0;
      
      Console.WriteLine("Give numbers:");
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        sum = sum + input;
        amount ++;
        if (input % 2 == 0)
        {
          even++;
        }
        else
        {
            odd++;
        }
      }
      double average = (double)sum / amount;

      Console.WriteLine("Thx! Bye!");
      Console.WriteLine("Sum: " + sum);
      Console.WriteLine("Numbers: " + amount);
      Console.WriteLine("Average: " + average);
      Console.WriteLine("Even: " + even);
      Console.WriteLine("Odd: " + odd);
    }
  }
}
