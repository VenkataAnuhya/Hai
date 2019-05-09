using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProgram
{
    class CakeFactory

    {
        public List<Cake> Cakes { get; set; }
        public CakeFactory()
        {
            Cakes = new List<Cake>();
        }
    }
}
