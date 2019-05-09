using System;

namespace Class_Object
{
    class Program
    {
        public static void Main(String[] args)
        {
            Book b = new Book();
            b.bName = "shekspear";
            Book b1 = new Book("baskerville", "sherlockholmes", 20);
            //Console.WriteLine(b.bName);
            Console.WriteLine( b1.bName + '\n' + b1.bAuthor + '\n' + b1.no_of_books+'\n'+b.bName);
            Console.ReadLine();
            
        }
    }
}
