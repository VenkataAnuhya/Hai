//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Delegates
//{
//    class LambdaExpressions
//    {
//        public static void Main(string[] args)
//        {
//             /* AddDelegate1 ad1 = delegate (int a, int b)//anonymous method in dlelgetes
//             {
//                 Console.WriteLine("adding two integers:" + (a + b));
//             };*///as the parameter list is known by delegate to simplify the code we go for lambda expressions

//            AddDelegate1 a1 = (a, b) =>
//            {
//                Console.WriteLine("adding two integers:" + (a + b));
//            };

//            a1(2, 5);

//            /*  PrintDelegate2 pd1 = delegate (string name)
//              {
//                  return "Hai" + name;
//              };*/

//            PrintDelegate2 p2 = name =>
//            {
//                return "Hai" + name;
//            };


//            string res = p2("  Bhavagna");

//            Console.WriteLine("name:  " + res);
//            Console.ReadLine();


//        }
//    }
//}

