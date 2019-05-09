using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    class constructorInheritance
    {
        public constructorInheritance()
        {
            Console.WriteLine("i am a parent constructor");
        }
        public constructorInheritance(string name)
        {
            Console.WriteLine(name);
        }

    }

    class childConstructor:constructorInheritance
    {
        public childConstructor():base("hai i am base class parametrized constructor")
        {
            Console.WriteLine("i am child constructor");
        }
    }

    class Program1
    {
     /*   public static void Main(String[] args)
        {
            childConstructor c = new childConstructor();
            Console.ReadLine();
        }*/
    }
}
