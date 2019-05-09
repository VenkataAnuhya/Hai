using System;
using System.Collections.Generic;
using System.Text;

namespace methodHiding
{
    class program
    {
        public static void Main(String[] args)
        {
            child1 c1 = new child1();
            c1.contract_salary = 35000;
            c1.perm_salary = 70000;
            c1.totalSalary();


            child2 c2= new child2();
            c2.contract_salary = 35000;
            c2.perm_salary = 70000;
            c2.totalSalary();
         
            ((Base1)c1).totalSalary();//type casting n using the parent class method with child class type--now returns the total salary 

            Console.ReadLine();
        }
    }
}
