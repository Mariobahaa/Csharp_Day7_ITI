using System;
using System.Collections.Generic;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //LibraryEngine libraryEngine = new LibraryEngine();
            Book book = new Book("ISBN", "Hello C#", new string[1] { "Mario" }, DateTime.Now, 50);
            BDelegate fptr = new BDelegate( BookFunctions.GetPrice);
            List<Book> books = new List<Book>();
            //books.Add(book);
            LibraryEngine.ProcessBooks(books,fptr);
        }
    }
}
