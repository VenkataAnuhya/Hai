using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
   public static class staticClass
    {
        static int a;

        public static int b
        {
            set
            {
                a = value;
            }
            get
            {
                return a;
            }
        }
    }
}
