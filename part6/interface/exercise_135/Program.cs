﻿using System;
using System.Collections.Generic;

namespace exercise_135
{
    class Program
    {
        public static void Main(string[] args)
        {
          JokeManager manager = new JokeManager();
          UserInterface ui = new UserInterface(manager);
          ui.Start();
            /*JokeManager manager = new JokeManager();
            manager.AddJoke("What is red and smells of blue paint? - Red paint.");
            manager.AddJoke("What is blue and smells of red paint? - Blue paint.");

            Console.WriteLine("Drawing jokes:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(manager.DrawJoke());
            }

            Console.WriteLine("");
            Console.WriteLine("Printing jokes:");
            manager.PrintJokes();*/
            /*List<string> jokes = new List<string>();
            Console.WriteLine("What a joke!");

            while (true)
            {
              Console.WriteLine("Commands:");
              Console.WriteLine(" 1 - add a joke");
              Console.WriteLine(" 2 - draw a joke");
              Console.WriteLine(" 3 - list jokes");
              Console.WriteLine(" X - stop");

              string command = Console.ReadLine();

              if (command == "X")
              {
                break;
              }

              if (command == "1")
              {
                Console.WriteLine("Write the joke to be added:");
                string joke = Console.ReadLine();
                jokes.Add(joke);
              }
              else if (command == "2")
              {
                Console.WriteLine("Drawing a joke.");

                if (jokes.Count == 0)
                {
                  Console.WriteLine("Jokes are in short supply.");
                }
                else
                {
                  Random draw = new Random();
                  int index = draw.Next(0, jokes.Count);
                  Console.WriteLine(jokes[index]);
                }

              }
              else if (command == "3")
              {
                Console.WriteLine("Printing the jokes.");
                foreach (string joke in jokes)
                {
                  Console.WriteLine(joke);
                }
              }
            }*/
        }
    }
}