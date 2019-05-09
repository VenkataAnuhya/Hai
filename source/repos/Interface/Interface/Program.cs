using System;

namespace Interface
{
    interface Isample
    {
        void getInf();
    }
    class Sample : Isample
    {
        public void getInf()//implicit interface
        {
            //throw new NotImplementedException
            Console.WriteLine("I am the sample interface");
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.getInf();
            

            ExpilcitInterface e = new ExpilcitInterface();
            e.print();
            ((IexplicitInterface1)e).print();// type cast is -----1 method

            IinstanceInterface1 i1 = new InstanceInterface();//invoking interface methods by interface ref variable----2 method
            IinstanceInterface2 i2 = new InstanceInterface();

            i1.printer();
            i2.printer();
            Console.ReadLine();
        }
    }
}
