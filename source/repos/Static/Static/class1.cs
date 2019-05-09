using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
    class class1
    {
        static string name;
        internal int age;
        static class1()
        {
            Console.WriteLine("i am static constructor");
            name = "IVAnuhyaReddy";
            
        }
        public static void staticMethod()
        {
            Console.WriteLine("iam static method");

        }
        public void instanceMethod()
        {
            age = 50;
            Console.WriteLine("i am instance method");
        }

    }
}
