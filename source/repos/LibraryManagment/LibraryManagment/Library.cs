using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace LibraryManagment
{
    class Library
    {
        //private IList<Book> books;

        public List<Book> Books { get; set; }

        public Library()
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

