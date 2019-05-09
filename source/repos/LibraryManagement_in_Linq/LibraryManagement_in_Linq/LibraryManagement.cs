using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement_in_Linq
{
    class LibraryManagement
    {
        public List<Book> Books { get; set; }

        public LibraryManagement()
        {
            Books = new List<Book>()
            {
                new Book() { Id = 1, Name = "Hound of Baskerville" },
                new Book() { Id = 3, Name = "Treasure Hunt" },
                new Book() { Id = 4, Name = "Gelliver Travels" },
                new Book() { Id = 2, Name = "Harry Potter" }
            };

        }
    }
}
