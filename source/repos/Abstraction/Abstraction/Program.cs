using System;

namespace Abstraction
{
    abstract class Program
    {
        public abstract int d{ get; set; }
        public abstract void add(int a, int b);
        public int Mul(int a, int b)
        {
            return a * b;
        }

    }
    class Sample:Program
    {
        public override int d { get; set; }

        public override void add(int a, int b)
        {
            Console.WriteLine("addition:"+ (a + b));
        }
    }
    class FinalProgram
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.add(2, 3);
            s.d = 20;
            Program p = s;
            p.add(100, 100);
            Console.WriteLine("multiplication:"+s.Mul(10,10));
            Console.ReadLine();
        }
    }
}
