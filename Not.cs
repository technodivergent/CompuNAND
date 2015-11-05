using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuNAND
{
    class Not : LogicGate
    {
        public Not(LogicGate LG)
        {
            bool p = LG.ToBool();
            this.c = NOT(p);
        }

        public Not(bool a)
        {
            bool p = a;
            this.c = NOT(p);
        }

        public Not(int a)
        {
            bool p = Convert.ToBoolean(a);
            this.c = NOT(p);
        }

        private bool NOT(bool p)
        {
            Nand NAND = new Nand(p, p);
            bool z = NAND.ToBool();
            return z;
        }
    }
}
