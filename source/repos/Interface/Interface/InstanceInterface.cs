using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
        interface IinstanceInterface1
        {
            void printer();
        }
        interface IinstanceInterface2
        {
            void printer();
        }
    
       public class InstanceInterface : IinstanceInterface1, IinstanceInterface2
    {
            void IinstanceInterface1.printer()
            {
                //throw new NotImplementedException();
                Console.WriteLine("print method from 3");////////Explicit interface//no access specifier required
            }

            void IinstanceInterface2.printer()
            {
                Console.WriteLine("print method from 4"); ;
            }
        

        }

    }
