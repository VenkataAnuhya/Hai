using System;

namespace SpecialCharCount
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string choice;
            do
            {
                
                string name;
                int sp, digits, alp, blank;
                blank = sp = digits = alp = 0;
                Console.WriteLine("enter the string:");
                name = Console.ReadLine();
                for (int i = 0; i <= name.Length - 1; i++)
                {
                    if ((name[i] >= 'A' && name[i] <= 'Z') || (name[i] >= 'a' && name[i] <= 'z'))
                    {
                        alp++;
                    }
                    else if (name[i] >= '0' && name[i] <= '9')
                    {
                        digits++;
                    }
                    else if (name[i] == ' ')
                        blank++;
                    else
                        sp++;

                }
                Console.WriteLine("no.of alphabets {0}", alp);
                Console.WriteLine("no.of digits {0}", digits);
                Console.WriteLine("no.of specialcharacters {0}", sp);
                Console.WriteLine("no.of blank {0}", blank);
                Console.ReadKey();
                Console.WriteLine("if do u want to continue: say yes else exit");
                choice = Console.ReadLine();


            }
            while (choice == "yes");
        }
    }
}