using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuNAND
{
    class Or : LogicGate
    {
        public Or(LogicGate LG1, LogicGate LG2)
        {
            bool p = LG1.ToBool();
            bool q = LG2.ToBool();
            this.c = OR(p, q);
        }

        public Or(bool a, bool b)
        {
            bool p = a;
            bool q = b;
            this.c = OR(p, q);
        }

        public Or(int a, int b)
        {
            bool p = Convert.ToBoolean(a);
            bool q = Convert.ToBoolean(b);
            this.c = OR(p, q);
        }

        private bool OR(bool p, bool q)
        {
            Not NOTP = new Not(p);
            Not NOTQ = new Not(q);
            Nand NAND = new Nand(NOTP, NOTQ);

            bool z = NAND.ToBool();
            return z;
        }
    }
}
