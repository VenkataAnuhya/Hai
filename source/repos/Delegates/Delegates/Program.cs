//using System;
//using System.Collections;

//namespace Delegates
//{
//    public delegate void AddDelegate(int a, int b);
//    public delegate string PrintDelegate(string name);

//    class Program
//    {
//        public void AddNum(int a, int b)
//        {
//            Console.WriteLine("adding two integers:" + (a + b));
//        }
//        public static string PrintName(string name)
//        {

//            return "Hai" + name;
//        }
//    }
//    class Test
//    {
//        static void Main(string[] args)
//        {
//            Program p1 = new Program();
//            AddDelegate ad = new AddDelegate(p1.AddNum);
//            // p1.AddNum(2, 5);
//            /* ad(2,5);also can be written as*/
//            ad.Invoke(4, 56);
//            // PrintDelegate pd = new PrintDelegate(Program.PrintName);can also be written as
//            PrintDelegate pd = Program.PrintName;

//            /*string res= pd.Invoke("Bhavagna"); or we can invoke it by */
//            string res = pd("  anuhya");
//            //  string res=Program.PrintName("Bhavagna");
//            Console.WriteLine("name:  " + res);
//            Console.WriteLine("string name: " + res);
//            Console.ReadLine();
//        }
//    }
//}
