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

        public int Calc()
        {
            return c ? 1 : 0;
        }

        public void Write()
        {
            Console.Write(Calc());
        }

        public void WriteLine()
        {
            Console.WriteLine(Calc());
        }
    }
}
