using System;
using System.Collections.Generic;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //LibraryEngine libraryEngine = new LibraryEngine();
            Book book1 = new Book("ISBN1", "Hello C#", new string[1] { "Mario" }, DateTime.Now, 50);
            Book book2 = new Book("ISBN2", "Hello C# - Advanced", new string[2] { "Mario","Mario Bardo" }, DateTime.Now, 50);

            List<Book> books = new List<Book>();
            books.Add(book1);
            books.Add(book2);

            Console.WriteLine("User Defined Delegate Datatype");
            BDelegate fptr = new BDelegate(BookFunctions.GetPrice);
            LibraryEngine.ProcessBooks(books,fptr);
            Console.WriteLine("");

            /**/
            Console.WriteLine("BCL");
            Func<Book, String> fptrBCL = new Func<Book, String>(BookFunctions.GetPrice);
            LibraryEngine.ProcessBooks(books, fptrBCL);
            Console.WriteLine("");

            Console.WriteLine("Anonymous Function");
            BDelegate fptrAn = delegate (Book B) { return B.ISBN; };
            LibraryEngine.ProcessBooks(books, fptrAn);
            Console.WriteLine("");


            //
            Console.WriteLine("Lambda Expression");
            BDelegate fptrLambda = (B) => B.Title;
            LibraryEngine.ProcessBooks(books, fptrLambda);
            Console.WriteLine("");


        }
    }
}
