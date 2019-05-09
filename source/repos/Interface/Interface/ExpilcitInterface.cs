using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IexplicitInterface1
    {
        void print();
    }
    interface IexplicitInterface2
    {
        void print();
    }
    class ExpilcitInterface : IexplicitInterface1,IexplicitInterface2
    {
        void IexplicitInterface1.print()
        {
            //throw new NotImplementedException();
            Console.WriteLine("print method from 1");////////Explicit interface//no access specifier required
        }

       public void print()
        {
            //throw new NotImplementedException();
            Console.WriteLine("print method from 2");////////defult interface//should be public
        }

    }
   /* class program
    {
        public static void Main(String[] args)
        {
            ExpilcitInterface e = new ExpilcitInterface();
            e.print();
            ((IexplicitInterface1)e).print();
            Console.ReadLine();
        }
    }*/
    
}
