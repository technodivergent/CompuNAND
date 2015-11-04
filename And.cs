using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuNAND
{
    class And : LogicGate
    {
        private bool c;

        public And(int a, int b)
        {
            bool p = Convert.ToBoolean(a);
            bool q = Convert.ToBoolean(b);
            this.c = AND(p, q);
        }

        private bool AND(bool p, bool q)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine(c ? 1 : 0);
        }
    }
}
