using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuNAND
{
    public class And : LogicGate
    {
        public And(LogicGate LG1, LogicGate LG2)
        {
            bool p = LG1.ToBool();
            bool q = LG2.ToBool();
            this.c = AND(p, q);
        }

        public And(bool p, bool q)
        {
            this.c = AND(p, q);
        }

        public And(int a, int b)
        {
            bool p = Convert.ToBoolean(a);
            bool q = Convert.ToBoolean(b);
            this.c = AND(p, q);
        }

        private bool AND(bool p, bool q)
        {
            Nand NAND = new Nand(p, q);
            Not NOT = new Not(NAND);
            bool z = NOT.ToBool();
            return z;
        }
    }
}
