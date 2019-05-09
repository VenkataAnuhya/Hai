using System;
using System.Collections.Generic;
using System.Text;

namespace methodHiding
{
    class child1:Base1
    {
        public new void totalSalary()
        {
            total = perm_salary + contract_salary;
            Console.WriteLine("total_Salary"+total);
        }
    }
    class child2:Base1
    {
        
    }
}
