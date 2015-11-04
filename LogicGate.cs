using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuNAND
{
    class LogicGate
    {
        protected bool c;

        public void Print()
        {
            Console.WriteLine(c ? 1 : 0);
        }
    }
}
