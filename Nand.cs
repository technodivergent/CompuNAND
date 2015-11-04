using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuNAND
{
    class Nand : LogicGate
    {
        public Nand(int a, int b)
        {
            bool p = Convert.ToBoolean(a);
            bool q = Convert.ToBoolean(b);
            this.c = NAND(p, q);
        }

        private bool NAND(bool p, bool q)
        {
            bool z = true;

            if (p)
                if (q)
                    z = false;

            return z;
        }
    }
}
