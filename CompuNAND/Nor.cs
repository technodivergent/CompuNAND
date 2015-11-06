using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuNAND
{
    public class Nor : LogicGate
    {
        public Nor(LogicGate LG1, LogicGate LG2)
        {
            bool p = LG1.ToBool();
            bool q = LG2.ToBool();
            this.c = NOR(p, q);
        }

        public Nor(bool p, bool q)
        {
            this.c = NOR(p, q);
        }

        public Nor(int a, int b)
        {
            bool p = Convert.ToBoolean(a);
            bool q = Convert.ToBoolean(b);
            this.c = NOR(p, q);
        }

        private bool NOR(bool p, bool q)
        {
            Or OR = new Or(p, q);
            Not NOT = new Not(OR);

            bool z = NOT.ToBool();
            return z;
        }
    }
}
