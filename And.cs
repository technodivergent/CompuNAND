using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuNAND
{
    class And : LogicGate
    {
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
    }
}
