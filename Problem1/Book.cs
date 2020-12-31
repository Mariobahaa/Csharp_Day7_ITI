using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public delegate O GenericBDelegate<in T, out O>(T X);
    public delegate string BDelegate(Book book);
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string _ISBN, string _Title,
        string[] _Authors, DateTime _PublicationDate,
       decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            StringBuilder s = new StringBuilder("", 100);
            for(int i=0;i<B.Authors?.Length;i++)
            {
                s.Append($"{B.Authors[i]} ,");
            }
            return s.ToString();
        }
        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
    }
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList
       ,BDelegate fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        public static void ProcessBooks(List<Book> bList
       , Func<Book, String> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
