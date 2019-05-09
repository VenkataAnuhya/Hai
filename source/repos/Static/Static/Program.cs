using System;

namespace Static
{
    internal static class Program 
    {
        static void Main(string[] args)
        {
            class1 p = new class1();
            PropertyClass pc = new PropertyClass();
            p.instanceMethod();
            p.age = 40;
            class1.staticMethod();
            Console.WriteLine("age"+p.age);
            pc.A = 20;
            staticClass.b = 10;
            Console.WriteLine("valu"+staticClass.b+'\n'+"propval"+pc.A);
            Console.ReadLine();
        }
    }
}
