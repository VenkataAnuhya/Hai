using System;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Books = new string[10];
            AddBook a = new AddBook();
            int id,n;
            string name;
            n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the book id:");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the book name:");
                name = Console.ReadLine();
                a.add(id, name);
            }
            
            Console.ReadLine();
        }
    }
}
