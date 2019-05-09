using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                string str;
                Console.WriteLine("enter the string:");
                str = Console.ReadLine();
                int i = str.Length - 1, j;
                int count = 1;
                for (j = 0; j <= i; j++)//also u can write for(j=i;j>=0;j--)
                {
                    if (str[j] == ' ' && str[j + 1] != ' ')
                    {
                        count++;
                    }

                }
                Console.WriteLine("no.of words {0}", count);
                Console.WriteLine("do you want to continue say yes else no");
                choice = Console.ReadLine();

            } while (choice == "yes");


    }
    }
}
