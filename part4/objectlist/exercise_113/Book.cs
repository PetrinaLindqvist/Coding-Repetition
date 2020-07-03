using System;

namespace exercise_113
{
    public class Book
    {
        public string title {get; set;}
        public int numOfPages {get; set;}

        public string publicationsYear {get; set;}

        public Book(string title, int numOfPages, string publicationsYear)
        {
            this.title = title;
            this.numOfPages = numOfPages;
            this.publicationsYear = publicationsYear;
        }

        public override string ToString()
        {
           return this.title + ", " + this.numOfPages + " pages, " + this.publicationsYear;
        }
    }
}