using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuNAND
{
    public class Nand : LogicGate
    {
        public Nand(LogicGate LG1, LogicGate LG2)
        {
            bool p = LG1.ToBool();
            bool q = LG2.ToBool();
            this.c = NAND(p, q);
        }

        public Nand(bool a, bool b)
        {
            bool p = a;
            bool q = b;
            this.c = NAND(p, q);
        }

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
