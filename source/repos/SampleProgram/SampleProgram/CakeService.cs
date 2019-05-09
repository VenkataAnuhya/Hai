using System;
using System.Collections.Generic;vgvhgmh
using System.Collections;
using System.Linq;
using System.Text;

namespace SampleProgram
{
    public class CakeService
    {
        public Cake AddCake(ref int num, IList<Cake> cakes)
        {

            Console.WriteLine("Enter the Cake Name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the cake cost :");
            var cost = Convert.ToInt32(Console.ReadLine());
            num++;
            Cake vennela = new Cake() { Id = num, Name = name, Cost = cost };
            // var vennela = cakes.Select((a,b,c)=>new { a=num,b=name,c=cost });---doubt
            return vennela;

        }
        public void DisplayCakes(IList<Cake> cakes)
        {
            Console.WriteLine("\nCake Details:\n-------------------");
            //  IEnumerable<Cake> c=cakes.Select(a=>a);
            IEnumerable<Cake> c = from cak in cakes select cak;
            //   cakes.for
            foreach (Cake c1 in c)
            {
                // Console.WriteLine("Name :" + c.Name + " cost:" + c.Cost + "Id" + Id);
                Console.WriteLine($"Name: {c1.Name}, Cost: {c1.Cost} --->Id: {c1.Id}");
            }

        }

        public void SearchCake(IList<Cake> cakes)
        {
            Console.WriteLine("Enter the Cakeid:");
            var id = Convert.ToInt32(Console.ReadLine());
            //IEnumerable<Cake> cak = cakes.Where(ck => ck.Id==id);
            Cake cak = cakes.Where(ck => ck.Id == id).SingleOrDefault();
            Console.WriteLine($"Name: {cak.Name} Cost: {cak.Cost} --->Id: {cak.Id}");
        }

        public void UpdateCake(IList<Cake> cakes)
        {
            Console.Write("Updation based on Id or Name:");
            var input = Console.ReadLine();
            if (string.Compare(input, "id", true) == 0)
            {

                Console.WriteLine("Updation based on id :");
                var id = Convert.ToInt32(Console.ReadLine());
                Cake cake = cakes.Where(cak => cak.Id == id).FirstOrDefault();
                Console.WriteLine("Enter 1.'yes' if u want to update Name\n 2.'no' if you want to update cost\n3.'Both' update cost n name");
                string value = Console.ReadLine();
                if (string.Compare(value, "yes", true) == 0)
                {
                    cake.Name = Console.ReadLine();
                }
                else if (string.Compare(value, "no", true) == 0)
                {
                    Console.WriteLine("Enter Cost if you want to update:");
                    cake.Cost = Convert.ToInt32(Console.ReadLine());
                }
                else if (string.Compare(value, "both", true) == 0)
                {
                    Console.WriteLine("Enter the name:");
                    cake.Name = Console.ReadLine();
                    Console.WriteLine("Enter Cost if you want to update:");
                    cake.Cost = Convert.ToInt32(Console.ReadLine());
                }
                else
                    Console.WriteLine("Incorrect input");
                Console.WriteLine($"ID:{cake.Id} Name: {cake.Name} Cost: {cake.Cost}");

                //    foreach (Cake c in cakes)
                //    {
                //        if (c.Id == id)
                //        {
                //            Console.WriteLine("press 1. if u want to update cost " +
                //                "and 2. if you want update name and " +
                //                "3.press both if u want update both");

                //            int choice = Convert.ToInt32(Console.ReadLine());
                //            if (choice == 1)
                //            {
                //                Console.WriteLine("Update the cost:");
                //                c.Cost = Convert.ToInt32(Console.ReadLine());
                //                Console.WriteLine("List of Cakes before updation ");
                //                DisplayCakes(cakes);
                //                Console.WriteLine("CakeId: " + c.Id + "\tCake_Name: " + c.Name + "\tcake_Cost" + c.Cost);
                //                Console.WriteLine("Cake updated Successfully");
                //                Console.WriteLine("List of Cakes after updation");
                //                DisplayCakes(cakes);

                //            }
                //            else if (choice == 2)
                //            {
                //                Console.WriteLine("Update Name:");
                //                c.Name = Console.ReadLine();
                //                Console.WriteLine("List of Cakes before updation ");
                //                DisplayCakes(cakes);
                //                Console.WriteLine("CakeId: " + c.Id + "\tCake_Name: " + c.Name + "\tcake_Cost" + c.Cost);
                //                Console.WriteLine("Cake updated Successfully");
                //                Console.WriteLine("List of Cakes after updation");
                //                DisplayCakes(cakes);
                //            }
                //            else if (choice == 3)
                //            {
                //                Console.WriteLine("Update cost:");
                //                c.Cost = Convert.ToInt32(Console.ReadLine());
                //                Console.WriteLine("Update Name:");
                //                c.Name = Console.ReadLine();
                //                Console.WriteLine("List of Cakes before updation ");
                //                DisplayCakes(cakes);
                //                Console.WriteLine("CakeId: " + c.Id + "\tCake_Name: " + c.Name + "\tcake_Cost" + c.Cost);
                //                Console.WriteLine("Cake updated Successfully");
                //                Console.WriteLine("List of Cakes after updation");
                //                DisplayCakes(cakes);

                //            }
                //            else
                //                Console.WriteLine("incorrect input");
                //        }
                //        else
                //            Console.WriteLine("incorrect input");
                //    }
            }
            else if (string.Compare(input, "name", true) == 0)
            {
                Console.WriteLine("Updation based on name:");
                var name = Console.ReadLine();
                Cake cake = cakes.Where(cak => cak.Name == name).FirstOrDefault();
                Console.WriteLine("Enter '1.yes' if u want to update Name\n 2.'no' if you want to update cost\n3.Both cost n name:");
                string value = Console.ReadLine();
                if (string.Compare(value, "yes", true) == 0)
                {
                    Console.WriteLine("Enter the name:");
                    cake.Name = Console.ReadLine();
                }
                else if (string.Compare(value, "no", true) == 0)
                {
                    Console.WriteLine("Enter Cost if you want to update:");
                    cake.Cost = Convert.ToInt32(Console.ReadLine());
                }
                else if (string.Compare(value, "both", true) == 0)
                {
                    Console.WriteLine("Enter the name:");
                    cake.Name = Console.ReadLine();
                    Console.WriteLine("Enter Cost if you want to update:");
                    cake.Cost = Convert.ToInt32(Console.ReadLine());
                }
                else
                    Console.WriteLine("Incorrect output");
                Console.WriteLine($"ID:{cake.Id} Name: {cake.Name} Cost: {cake.Cost}");
            }
            //    foreach (Cake c1 in cakes)
            //    {
            //        if (string.Compare(c1.Name, name, true) == 0)
            //        {
            //            Console.WriteLine("press 1. if u want to update cost " +
            //                "and 2. if you want update name and " +
            //                "3.press both if u want update both");

            //            int choice = Convert.ToInt32(Console.ReadLine());
            //            if (choice == 1)
            //            {
            //                Console.WriteLine("Update cost :");
            //                c1.Cost = Convert.ToInt32(Console.ReadLine());
            //                Console.WriteLine("List of Cakes before updation ");
            //                DisplayCakes(cakes);
            //                Console.WriteLine("CakeId: " + c1.Id + "\tCake_Name: " + c1.Name + "\tcake_Cost" + c1.Cost);
            //                Console.WriteLine("Cake updated Successfully");
            //                Console.WriteLine("List of Cakes after updation");
            //                DisplayCakes(cakes);
            //            }
            //            else if (choice == 2)
            //            {
            //                Console.WriteLine("Update Name :");
            //                c1.Name = Console.ReadLine();
            //                Console.WriteLine("List of Cakes before updation ");
            //                DisplayCakes(cakes);
            //                Console.WriteLine("CakeId: " + c1.Id + "\tCake_Name: " + c1.Name + "\tcake_Cost" + c1.Cost);
            //                Console.WriteLine("Cake updated Successfully");
            //                Console.WriteLine("List of Cakes after updation");
            //                DisplayCakes(cakes);
            //            }
            //            else if (choice == 3)
            //            {
            //                Console.WriteLine("cost Update :");
            //                c1.Cost = Convert.ToInt32(Console.ReadLine());
            //                Console.WriteLine("name update:");
            //                c1.Name = Console.ReadLine();
            //                Console.WriteLine("List of Cakes before updation ");
            //                DisplayCakes(cakes);
            //                Console.WriteLine("CakeId: " + c1.Id + "\tCake_Name: " + c1.Name + "\tcake_Cost" + c1.Cost);
            //                Console.WriteLine("Cake updated Successfully");
            //                Console.WriteLine("List of Cakes after updation");
            //                DisplayCakes(cakes);
            //            }
            //            else
            //                Console.WriteLine("incorrect input");
            //        }
            //        else
            //        {
            //            Console.WriteLine("incorrect input");
            //        }
            //    }
        }
        public void DeleteCake(IList<Cake> cakes)
        {
            Console.WriteLine("\nEnter the Cakeid's to be deleted");
            string num = Console.ReadLine();
            int i = 0;
            string[] id = num.Split(',');
            int len = id.Length;
            Console.WriteLine("\nList before deletion:");
            DisplayCakes(cakes);
            while (i < len)
            {
                Cake cak = cakes.Where(c1 => c1.Id == Convert.ToInt32(id[i])).SingleOrDefault();
                cakes.Remove(cak);
                Console.WriteLine($"{id[i]} ====>Deleted Successfully\n");
                i++;
            }
            Console.WriteLine("\nList after deletion\n-------------------");
            DisplayCakes(cakes);

        }
    }
}







