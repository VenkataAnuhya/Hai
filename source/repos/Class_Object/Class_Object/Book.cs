using System;
namespace Class_Object
{
    public class Book
    {
        public string bName;
        public string bAuthor;
        public int no_of_books;

        public Book()
        {
        }

        public Book(string name, string author, int no)
        {
            bName = name;
            bAuthor = author;
            no_of_books = no;
           // Console.ReadLine(bName + '\n' + bAuthor + '\n' + no_of_books);
        }
    }
}