using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagment
{
    class Book
    {
        //Pascal cased
        public int BookId { get; set; }
        public string BName { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //use short hand for list initialization
            Book b1 = new Book() { BookId = 1, BName = "Hound of Baskerville" };
            Book b2 = new Book() { BookId = 3, BName = "Treasure Hunt" };
            Book b3 = new Book() { BookId = 4, BName = "Gelliver Travels" };
            Book b4 = new Book() { BookId = 2, BName = "Harry Potter" };
            IList<Book> books = new List<Book>() { b1, b2, b3, b4 };

            //move the cw to a seperate method
            Console.WriteLine("Welcome to the Library Portal");
            Console.WriteLine("\nSelect the following Operations as per your requirement");
            Console.WriteLine("\n1.Display the List of Books");
            Console.WriteLine("2.Get/search the Book details you wish based on the ID");
            Console.WriteLine("3.Remove the Book i.e. not realted to the library");
            Console.WriteLine("4.Add the Book you like");

            string choice;
            do
            {
                int input = Convert.ToInt32(Console.ReadLine());

                //Sepeare the logic to different private methods
                if (input == 1)
                {
                    Console.WriteLine("The list of Books:\n");
                    foreach (Book b in Books)
                    {
                        Console.WriteLine("Book_Id: " + b.bookId + "\tBook_Name: " + b.bName);
                    }
                }

                else if (input == 2)
                {
                    //try replacing the logic with where linq
                    Console.WriteLine("enter the id of book u want to search ");
                    Action<int> search = (a) => {
                        bool c = false;
                        foreach (Book b in books)
                        {
                            c = true;
                            if (a == b.BookId)
                            {
                                Console.WriteLine("Book_Id: " + b.BookId + "\tBook_Name: " + b.BName);
                            }
                        }
                        if (!c)
                            Console.WriteLine("Enter the correct input");
                    };
                    int userid = Convert.ToInt32(Console.ReadLine());
                    search(userid);
                }


                else if (input == 3)
                {
                    Console.WriteLine("enter the id of book u want to delete ");
                    Action<int> delete = (a) =>
                    {
                        bool c = false;
                        foreach (Book b in books)
                        {

                            c = true;
                            if (a == b.BookId)
                            {

                                books.RemoveAt(a);
                                Console.WriteLine("book deleted");
                                Console.WriteLine("Books list:\nBook_Id: " + b.BookId + "\tBook_Name: " + b.BName);

                            }
                        }
                        if (!c)
                            Console.WriteLine("Enter the correct input");
                    };
                    int userid = Convert.ToInt32(Console.ReadLine());
                    delete(userid);
                }

                else if (input == 4)
                {
                    Console.WriteLine("give the id and name of the book u want to add ");
                    Action<int, string> Add = (a, name) =>
                    {


                        books.Add(new Book { BookId = a, BName = name });
                        foreach (Book b in books)
                        {
                            Console.WriteLine("Book_Id: " + b.BookId + "\tBook_Name: " + b.BName);
                        }


                    };
                    int id = Convert.ToInt32(Console.ReadLine());
                    string nam = Console.ReadLine();
                    Add(id, nam);

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
