using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[2];
            string[] names = new string[3];
            string[] vowels = new string[5];
            string[] words = { "Anu", "amu" };
            //numbers
            Console.WriteLine("enter the numbers up to 2:");
            for(int i=0;i<numbers.Length;i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //arrays are static
            //string
            Console.WriteLine("enter the names up to 3:");
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("printing");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            //printing the vowel
            vowels[0] = "a";
            vowels[1] = "e";
            vowels[4] = "i";
            vowels[3] = "o";
            Console.WriteLine("printing vowels");
            Console.WriteLine("vowel : "+vowels[4]);
            Console.WriteLine("word : "+words[0]);
                       
            Console.ReadLine();
        }
    }
}
