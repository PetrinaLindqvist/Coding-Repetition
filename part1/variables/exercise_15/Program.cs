using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a string:");
      string one = Console.ReadLine();
      
      Console.WriteLine("Give an integer:");
      int nbr = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Give a double:");
      double nbr2 = Convert.ToDouble(Console.ReadLine());
      

      Console.WriteLine("Give a boolean:");
      bool boolean = Convert.ToBoolean(Console.ReadLine());


      Console.WriteLine("Your string: " + one);
      Console.WriteLine("Your integer: " + nbr);
      Console.WriteLine("Your double: " + nbr2);
      Console.WriteLine("Your boolean: " + boolean);

    }
  }
}
