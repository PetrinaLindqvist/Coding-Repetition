using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?");
      int nbr = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Where from?");
      int nbr2 = Convert.ToInt32(Console.ReadLine());
      
      int sum = nbr2;
      while (nbr >= sum)
      {
        Console.WriteLine(sum);
        sum ++;
      }
      
    }
  }
}
