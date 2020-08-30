namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class TextInterface
  {
    // Create the userinterface here
    private List<Book> books;
    public TextInterface()
    {
      this.books = new List<Book>();  
    }

    public void Start()
    {
      while (true)
      {

        Console.WriteLine("Input the name of the book, empty stops:");
        string name = Console.ReadLine();

        if (name == "")
        {
          break;
        }

        Console.WriteLine("Input the age recommendation:");
        int age = Convert.ToInt32(Console.ReadLine());
        Book book = new Book(name, age);
        this.books.Add(book);
        // OR this.books.Add(new Book(name, age));
      }       
        Console.WriteLine(this.books.Count + " books in total.");
        Console.WriteLine("");
        Console.WriteLine("Books: ");
        this.books.Sort();
        
        
        /*OR!! foreach (Book books in books)
        {
          Console.WriteLine(books);
        }*/
        
        this.books.ForEach(Console.WriteLine);
       
        
    }
  }
}