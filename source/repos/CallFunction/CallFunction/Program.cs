using System;

namespace CallFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string name;
            Console.Write("enter the number ");

            num =Convert.ToInt32(Console.ReadLine());
            int c=Number(num);
           
            //or we can write this also// Console.WriteLine(Number(num));
            Console.WriteLine(c);

            Console.WriteLine("enter the name:");
            name = Console.ReadLine();
            Name(name);

            Console.ReadLine();
        }
        static int Number(int num)
        {
            int c = num + 5;
            return c;
        }

        static void Name(string name)
        {
            string myname = name + "reddy";
            Console.WriteLine(myname);
        }
    }
}
