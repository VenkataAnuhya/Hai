using System;
using System.Collections.Generic;
using System.Collections;

namespace CarFactory
{
    class Car : ICar
    {
        public string type { get; set; }

        public void Check()
        {

        }
    }

    class swift : Car
    {
        public new void Check()
        {
            Console.WriteLine("the swift car is checked '\n' it is in black color and  '\n' it is diseal car");

        }
    }
    class ritz : Car
    {
        public new void Check()
        {
            Console.WriteLine("the ritz car is checked '\n' it is in black color and  '\n' it is petrol car");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car() { type = "swift" };//to pass swift class as parameter we must use delegetes
            Car c2 = new Car() { type = "ritz" };
            int i = 1;
            IList<Car> cars = new List<Car>() { c1, c2 };
            Console.WriteLine("welcome to the Maruthi cars factory");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("the list of Maruthi cars:");
            foreach (Car c in cars)
            {
                Console.WriteLine(i + "." + c.type);
                i++;
            }
            Console.WriteLine("enter your choice of car:");
            string input = Console.ReadLine();
            foreach (Car c in cars)
            {
                if (string.Compare(input, c.type, true) == 0)
                {
                    Console.WriteLine("{0} car is created", c.type);

                }


            }

            bool flag = false;
            foreach (Car c in cars)
            {
                if (string.Compare(input, c.type, true) == 0)
                {
                    flag = true;
                    if (c.type == "swift")
                    {
                        swift s = new swift();
                        s.Check();
                    }
                    else if (c.type == "ritz")
                    {
                        ritz r = new ritz();
                        r.Check();
                    }

                }               

            }

            if(!flag)
            {
                Console.WriteLine("enter the correct input");
            }
            Console.ReadLine();

        }
    }
}
