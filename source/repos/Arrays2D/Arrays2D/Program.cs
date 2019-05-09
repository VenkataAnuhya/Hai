using System;

namespace Arrays2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] num = new int[2, 2];
            int[,] num1 = new int[2, 3];
            for (i = 0; i < 2; i++)
            {
                for(j=0; j < 2; j++)
                {
                    Console.Write("a['{0}']['{1}']:",i,j);
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("a['{0}']['{1}']:", i, j);
                    num1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("the numbers entered num:");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    //Console.Write("\n");
                    Console.Write("  "+num[i,j]+" ");
                   
                }
            }
            Console.Write("the numbers entered num1:");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    //Console.Write("\n");
                    Console.Write("  " + num1[i, j] + " ");

                }
            }
            Console.ReadLine();
        }
    }
}
