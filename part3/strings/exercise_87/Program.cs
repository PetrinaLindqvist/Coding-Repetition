using System;
using System.Collections.Generic;

namespace exercise_87
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }
                string[] parts = input.Split(" ");
                foreach (string word in parts)
                {
                    Boolean containsWord = word.Contains("av");
                    if (containsWord)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }

    }

}

