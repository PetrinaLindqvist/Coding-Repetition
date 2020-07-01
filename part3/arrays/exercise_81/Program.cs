using System;
using System.Collections.Generic;

namespace exercise_81
{
    class Program
    {
        public static void Main(string[] args)
        {
            // You can test your method here
            int[] array = { 5, 1, 3, 4, 2 };
            PrintNeatly(array);
        }

        public static void PrintNeatly(int[] array)
        {
          int i = 0;
          foreach (int number in array)
          {
            if (i < (array.Length - 1))
            {
              Console.Write(array[i] + ", ");
            }
            else
            {
              Console.Write(array[i]);
            }
            i++;
          }
          Console.WriteLine();
        } 
    }
}

