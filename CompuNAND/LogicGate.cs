using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuNAND
{
    public class LogicGate
    {
        protected bool c;

        public bool ToBool()
        {
            return c;
        }

        public void WriteLine()
        {
            Console.WriteLine(c ? 1 : 0);
        }
    }
}
