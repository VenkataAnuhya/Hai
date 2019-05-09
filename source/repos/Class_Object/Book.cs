using System;
namespace Class_Object
{
    public class Book
    {
        public static string bName;
        public static string bAuthor;
        public int no_of_books;

        public Book()
        {
            /* bName = name;
             bAuthor = author;
             no_of_books = no;*/
            Console.ReadLine(bName + '\n' + bAuthor + '\n' + no_of_books);
        }

        public Book(string name, string author, int no)
        {
            bName = name;
            bAuthor = author;
            no_of_books = no;
            Console.ReadLine(bName + '\n' + bAuthor + '\n' + no_of_books);
        }
    }
}