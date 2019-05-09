using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    class calculator
    {
        public int a, b;
           protected int c,m;
        public void add(int a,int b)
        {
            this.a = a;
            this.b = b;
            c = a + b;
        }
       
        public void sub(int a, int b)
        {
            this.a = a;
            this.b = b;
            m = a - b;
        }
        
    }
}
