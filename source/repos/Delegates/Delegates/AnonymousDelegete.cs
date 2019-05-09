using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate void AddDelegate1(int a, int b);
    public delegate string PrintDelegate2(string name);
    class AnonymousDelegete
    {
     /*  public static void Main(string[] args)
        {
            AnonymousDelegete p1 = new AnonymousDelegete();

            //AddDelegate1 ad = new AddDelegate1(p1.AddNum); or

            AddDelegate1 ad1 = delegate (int a, int b)//anonymous method in dlelgetes
             {
                 Console.WriteLine("adding two integers:" + (a + b));
             };


            // p1.AddNum(2, 5);
            ad1(2, 5);


            // PrintDelegate2 pd1 = AnonymousDelegete.PrintName;

            PrintDelegate2 pd1 = delegate (string name)
             {
                 return "Hai" + name;
             };

            /*string res= pd.Invoke("Bhavagna"); or we can invoke it by */

        //    string res = pd1("  Bhavagna");

            //  string res=Program.PrintName("Bhavagna");

        ////    Console.WriteLine("name:  " + res);
         //   Console.ReadLine();
            

      //  }
    }
}




