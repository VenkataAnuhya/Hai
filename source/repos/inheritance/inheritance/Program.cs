using System;

namespace inheritance
{
    class Program : calculator
    {
        int d, e, f, j;
        public void mul(int a, int b)
        {
            d = a * b;
            j = e + f;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            //Program p1 = new calculator();//not possible explicit conversation
            calculator c= new Program();

            childConstructor c1 = new childConstructor();//here the parametrized constructor is called from constrtrinheritance
           // childConstructor d = new childConstructor();//if base() not specified then defalt base constructr is initilised

            p.e = Convert.ToInt32(Console.ReadLine());
            p.f = Convert.ToInt32(Console.ReadLine());

            p.add(2, 5);
            p.mul(2, 5);
            p.sub(5,2);
            Console.WriteLine("add:"+p.c);
            Console.WriteLine("sub:"+p.m);
            Console.WriteLine("mul:"+p.d);
            Console.WriteLine("dynamic add:"+p.j); 
            Console.ReadLine();
            
        }
    }
}