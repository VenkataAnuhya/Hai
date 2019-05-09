using System;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, name1;
            int i;
            
            Console.WriteLine("enter the string:");
            name = Console.ReadLine();
            name1 = "";
            for (i = name.Length - 1; i >= 0; i--)
            {
                name1 += name[i];
            }

            Console.WriteLine("reversed string: {0}", name1);
            if (name == name1)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
            Console.ReadLine();
            


        }
    }
}
