using System;
using System.Collections.Generic;

namespace LibraryManagement_in_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryManagement library = new LibraryManagement();
            Book b = new Book();
            IList<Book> books = library.Books;

            void Display()
            {
                Console.WriteLine("Welcome to the Library Portal");
                Console.WriteLine("\nSelect the following Operations as per your requirement");
                Console.WriteLine("\n1.Display the List of Books");
                Console.WriteLine("2.Get/search the Book details you wish based on the ID");
                Console.WriteLine("3.Remove the Book i.e. not realted to the library");
                Console.WriteLine("4.Add the Book you like");
                Console.WriteLine("5.Update the Book");
            }
            Display();
            string choice;

            do
            {
                Console.WriteLine("Enter your choice:");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("The list of Books:\n");
                    b.DisplayBooks(books);
                }

                else if (input == 2)
                {
                    Console.WriteLine("enter the id of book u want to search ");
                    b.SearchBook(books);
                }


                else if (input == 3)
                {
                    Console.WriteLine("enter the id of book u want to delete ");
                    b.DeleteBook(books);
                }

                else if (input == 4)
                {
                    Console.WriteLine("give the id and name of the book u want to add ");
                    b.AddBook(books);

                }
                else if (input == 5)
                {
                    //Console.WriteLine("give the id and name of the book u want to update ");
                    b.UpdateBook(books);
                }

                else
                    Console.WriteLine("select the correct option");

                Console.WriteLine("if u want to continue press yes");
                choice = Console.ReadLine();

            } while (choice == "yes");
            Console.ReadLine();
        }
    }
}
