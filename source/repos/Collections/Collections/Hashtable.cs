using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;

namespace Collections
{
    class Hashtable1
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1,"Nithanth");
            ht.Add(2,27);
            ht.Add(3,10.524);
            ht.Add(4,"Amulya");
            ht.Add(5,"Kittu");
            ht.Add("sadwik","Sanju");
            ht.Remove(3);
          //  ht.Add(4,"prasad");
            foreach (object obj in ht.Values)
            {
                Console.WriteLine("values:"+obj);

            }

            Console.WriteLine();
            foreach (object obj in ht.Keys)
            {
                Console.WriteLine("keys:"+obj);
                Console.WriteLine("values:" + ht[obj]);

            }

            Console.ReadLine();
        }
    }

}