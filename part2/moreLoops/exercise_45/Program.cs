using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
    
      int input = Convert.ToInt32(Console.ReadLine());
      for (int i = 0; i <= input; i++)
      {
        Console.WriteLine(i);
      }

    }
  }
}
  /*THIS WORKS ALSO:
      int nbr = 0;
      int input = Convert.ToInt32(Console.ReadLine());
      while(input >= nbr )
      { 
        //Console.WriteLine(nbr);
        nbr++;
      }*/