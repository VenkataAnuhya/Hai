using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement_in_Linq
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //   public IList<Book> Books { get => list; set => list = Library.GetBooks(); }



        public void DisplayBooks(IList<Book> books)
        {
            foreach (Book b1 in books)
            {
                Console.WriteLine("BookID : " + b1.Id + "BookName : " + b1.Name);
            }

        }

        public void AddBook(IList<Book> books)
        {
            Action<int, string> Add = (bid, bname) =>
            {

                books.Add(new Book { Id = bid, Name = bname });

                Console.WriteLine("Book_Id: " + bid + "\tBook_Name: " + bname);
                Console.WriteLine("Book Added Successfully");
                Console.WriteLine("List of Books");

                foreach (Book b in books)
                {

                    Console.WriteLine("Book_Id: " + b.Id + "\tBook_Name: " + b.Name);
                }


            };
            Console.WriteLine("Enter the ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name: ");
            string nam = Console.ReadLine();
            Add(id, nam);
        }
        public void SearchBook(IList<Book> books)
        {
            Action<int> Search = (a1) =>
            {
                bool c = false;
                IEnumerable<Book> b1 = books.Where(a => a.Id == a1);
                foreach (Book b2 in b1)
                {
                    c = true;
                    Console.WriteLine("ID:" + b2.Id + "Name:" + b2.Name);
                }
                if (!c)
                    Console.WriteLine("Enter the correct input");
            };
            int userid = Convert.ToInt32(Console.ReadLine());
            Search(userid);
        }

        public void DeleteBook(IList<Book> books)
        {
            Action<int> delete = (id) =>
            {
                bool c = false;
                IEnumerable<Book> b1 = books.Where(a => a.Id == id);
                foreach (Book b2 in b1)
                {
                    c = true;
                    books.Remove(b2);
                    Console.WriteLine("ID:" + b2.Id + "Name:" + b2.Name+ "---->is deleted");
                    DisplayBooks(books);
                    return;
                }
                if (!c)
                    Console.WriteLine("Enter the correct input");
            };
            int userid = Convert.ToInt32(Console.ReadLine());
            delete(userid);
        }
        public void UpdateBook(IList<Book> books)
        {
            bool c = false;
            c = true;
            Console.Write("Updation based on Id or Name:");
            var input = Console.ReadLine();
            if (string.Compare(input, "id", true) == 0)
            {

                Console.WriteLine("Updation based on id :");
                Console.WriteLine("Enter the ID:");
                int userid = Convert.ToInt32(Console.ReadLine());
                var bid = userid;

                foreach (Book b in books)
                {

                    if (b.Id == bid)
                    {
                        Console.WriteLine("press 1. if u want to update id " +
                            "and 2. if you want update name and " +
                            "3.press both if u want update both");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine("Update the id:");
                            b.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Book_Id: " + b.Id + "\tBook_Name: " + b.Name);
                            Console.WriteLine("Book updated Successfully");
                            Console.WriteLine("List of Books");
                            DisplayBooks(books);
                        }

                        else if (choice == 2)
                        {
                            Console.WriteLine("Update Name:");
                            b.Name = Console.ReadLine();
                            Console.WriteLine("Book_Id: " + b.Id + "\tBook_Name: " + b.Name);
                            Console.WriteLine("Book updated Successfully");
                            Console.WriteLine("List of Books");
                            DisplayBooks(books);
                        }

                        else if (choice == 3)
                        {
                            Console.WriteLine("Update id:");
                            b.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Update Name:");
                            b.Name = Console.ReadLine();
                            Console.WriteLine("Book_Id: " + b.Id + "\tBook_Name: " + b.Name);
                            Console.WriteLine("Book updated Successfully");
                            Console.WriteLine("List of Books");
                            DisplayBooks(books);
                        }


                        else
                            Console.WriteLine("incorrect input");
                    }

                }
            }
            else if (string.Compare(input, "name", true) == 0)
            {
                Console.WriteLine("Updation based on name:");
                Console.WriteLine("Enter the name:");
                string name1 = Console.ReadLine();
                foreach (Book b1 in books)
                {
                    if (b1.Name == name1)
                    {
                        Console.WriteLine("press 1. if u want to update id " +
                            "and 2. if you want update name and " +
                            "3.press both if u want update both");

                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine("Update the id:");
                            b1.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Book_Id: " + b1.Id + "\tBook_Name: " + b1.Name);
                            Console.WriteLine("Book updated Successfully");
                            Console.WriteLine("List of Books");
                            DisplayBooks(books);
                        }

                        else if (choice == 2)
                        {
                            Console.WriteLine("Update Name:");
                            b1.Name = Console.ReadLine();
                            Console.WriteLine("Book_Id: " + b1.Id + "\tBook_Name: " + b1.Name);
                            Console.WriteLine("Book updated Successfully");
                            Console.WriteLine("List of Books");
                            DisplayBooks(books);
                        }

                        else if (choice == 3)
                        {
                            Console.WriteLine("Update cost:");
                            b1.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Update Name:");
                            b1.Name = Console.ReadLine();
                            Console.WriteLine("Book_Id: " + b1.Id + "\tBook_Name: " + b1.Name);
                            Console.WriteLine("Book updated Successfully");
                            Console.WriteLine("List of Books");
                            DisplayBooks(books);
                        }
                    }
                }
            }

            else
                Console.WriteLine("incorrect input");

            if (!c)
                Console.WriteLine("Enter the correct input");
        }
    }
}
