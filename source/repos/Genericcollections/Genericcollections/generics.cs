//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Genericcollections
//{
//    class generics
//    {
//        public void marks<T>(T marks1,T marks2)
//        {
//            dynamic m1 = marks1;
//            dynamic m2 = marks2;

//            Console.WriteLine("the total marks:"+(m1+m2));
//        }
//        public static void Main(string[] args)
//        {
//            generics g = new generics();
//            g.marks<float>(10,10);
//            g.marks<string>("anuhya", "reddy");//drawback ....type safe violation
//            Console.ReadLine();
//        }
//    }
//}
