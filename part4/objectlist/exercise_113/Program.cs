using System;
using System.Collections.Generic;

namespace exercise_113
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      // Remember also to create the file Book.cs and class in it!
      List<Book> books = new List<Book>();

      while (true)
      {
        Console.Write("Name: ");
        string title = Console.ReadLine();

        if (title == "")
        {
          break;
        }

        Console.Write("Pages: ");
        int numOfPages = Convert.ToInt32(Console.ReadLine());

        Console.Write("Publication year: ");
        string publicationsYear = Console.ReadLine();

        books.Add(new Book(title,numOfPages,publicationsYear));

      }

      Console.WriteLine();

      Console.Write("What information will be printed? ");
      string input = Console.ReadLine();

      foreach (Book items in books)
      { 
        if (input == "everything")
        {
          Console.WriteLine(items);
        }
        else if (input == "title")
        {
          Console.WriteLine(items.title); 
        }
        else
        {
          break;
        }
      }
    }
  }
}




