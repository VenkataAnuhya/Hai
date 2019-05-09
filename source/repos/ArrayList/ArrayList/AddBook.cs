using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayList
{
    class AddBook
    {
        int Bookid;
        string name;
        public void add(int id, string name)
        {
            Bookid= id;
            this.name = name;
            new bookList();
            
        }

    }
}
