using System;

namespace methodHiding
{
    class Base1
    {
        public int perm_salary;
        internal int contract_salary, total;
        public void totalSalary()
        {
            total = perm_salary + contract_salary;
            Console.WriteLine(total);
        }
    }
    
}
