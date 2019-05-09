using System;
using System.Collections.Generic;

namespace SampleProgram
{

    public class Program
    {
        public static void Main(string[] args)
        {
            CakeFactory cakeFactory = new CakeFactory();
            CakeService cakeService = new CakeService();
            int num = 0;
            IList<Cake> cakes = cakeFactory.Cakes;
            string choice;
            do
            {
                Console.WriteLine("enter your choice:\n1.Add Cake\n2.Delete Cake\n3.Update Cake\n4.Search Cake\n5.Display Cakes\nEnter your choice:");
                Console.WriteLine("===========================================================");
                Console.WriteLine();
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Cake flavor = cakeService.AddCake(ref num,cakes);
                    cakeFactory.Cakes.Add(flavor);
                    Console.WriteLine("\nCake Added successfully\n");
                    cakeService.DisplayCakes(cakes);

                }
                else if (input == 3)
                    cakeService.UpdateCake(cakes);
                else if (input == 5)
                    cakeService.DisplayCakes(cakes);
                else if (input == 2)
                    cakeService.DeleteCake(cakes);
                else if (input == 4)
                    cakeService.SearchCake(cakes);
                else
                    Console.WriteLine("select the correct option");
                Console.WriteLine("\n===========================================================");
                Console.WriteLine();
                Console.WriteLine("if u want to continue press yes");
                choice = Console.ReadLine();

            } while (string.Compare(choice,"yes",true)==0);
            Console.ReadLine();

        }
    }
}

