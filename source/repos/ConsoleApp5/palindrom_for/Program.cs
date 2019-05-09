using System;

namespace ConsoleApp5
{
    class Palindrom
    {
        private string string1;
        private string string2;

        public  Palindrom(string initial_name)
        {
            this.string1 = initial_name;
            this.string2 = "";
          
            for (int i = string1.Length-1;i>=0;i--)
            {
               string2 += string1[i];
            }
            Console.WriteLine("the reversed String is {0}",string2);
                
            if (initial_name == string2)
            {
                Console.WriteLine("it is palindrom");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }

         
        }

       
        static void Main(string[] args)
        {
            string initial_name;
            Console.WriteLine("enter the initial name:");
              initial_name = Console.ReadLine();
              Palindrom p = new Palindrom(initial_name);
            Console.ReadLine();
        }
    }
}
